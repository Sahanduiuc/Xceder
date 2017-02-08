﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Threading.Tasks;
using System;
using System.Reactive.Linq;
using Com.Xceder.Messages;
using System.Collections.Generic;

namespace Xceder
{
    [TestClass]
    public class TestClient
    {
        private bool lastSentHasError;
        private Request.RequestOneofCase lastSentRequestType;
        private ERRORCODE lastSentRequestResultCode;

        private bool isResponded = false;

        [TestMethod]
        public void TestLogin()
        {
            login();
        }

        [TestMethod]
        public void TestSubscribePrice()
        {
            var stream = login();
            var client = stream.XcederClient;

            var instruments = queryInstrument(client, "ES", Instrument.Types.PRODUCT.Fut);

            var requestTask = client.subscribePrice(instruments[0].Identity.Id);

            setLastSentRequestExpectation(false, Request.RequestOneofCase.MarketData);

            requestTask.Wait();

            assertSendRequestResult(requestTask);
        }

        private IList<Instrument> queryInstrument(Client client, string symbol, Instrument.Types.PRODUCT product = Instrument.Types.PRODUCT.Fut, Exchange.Types.EXCHANGE exch = Exchange.Types.EXCHANGE.NonExch, BROKER broker = BROKER.Xceder)
        {
            var requestTask = client.queryInstrument(symbol, product);

            setLastSentRequestExpectation(false, Request.RequestOneofCase.QueryRequest);

            requestTask.Wait();

            assertSendRequestResult(requestTask);

            var instruments = requestTask.Result.Item2.QueryResult.Instruments.Instrument;

            foreach (var i in instruments)
            {
                Assert.AreEqual(symbol, i.Identity.Symbol);

                if (product != Instrument.Types.PRODUCT.UnknownType)
                    Assert.AreEqual(product, i.Product);

                if (broker != BROKER.Xceder)
                    Assert.AreEqual(broker, i.Identity.Broker);

                if (exch != Exchange.Types.EXCHANGE.NonExch)
                    Assert.AreEqual(exch, i.Identity.Exchange);
            }

            return instruments;
        }

        private XcederStream connectToServer()
        {
            string server = "192.168.1.106";

            var stream = new XcederStream();

            stream.ResponseStream.Subscribe(onResponse);
            stream.NetworkErrorStream.Subscribe(onNetworkError);

            var task = stream.XcederClient.connect(server, 81);

            try
            {
                task.Wait();
            }
            catch (Exception ex)
            {

            }

            Assert.AreEqual(task.Status, TaskStatus.Faulted);

            task = stream.XcederClient.connect(server, 8082);

            task.Wait();

            Assert.IsTrue(task.Result);

            return stream;
        }

        private XcederStream login()
        {
            var stream = connectToServer();

            var client = stream.XcederClient;

            string userID = "testUser" + DateTime.Now;
            string pwd = "testUser";

            var requestTask = client.login(userID, "test");

            setLastSentRequestExpectation(false, Request.RequestOneofCase.Logon, ERRORCODE.InvalidUserid);

            requestTask.Wait();

            assertSendRequestResult(requestTask);

            requestTask = client.registerAccount(userID, userID + "@fake.com", pwd);

            setLastSentRequestExpectation(false, Request.RequestOneofCase.Account, ERRORCODE.Success);

            requestTask.Wait();

            assertSendRequestResult(requestTask);

            requestTask = client.login(userID, "pwd");

            setLastSentRequestExpectation(false, Request.RequestOneofCase.Logon, ERRORCODE.WrongPassword);

            requestTask.Wait();

            assertSendRequestResult(requestTask);

            requestTask = client.login(userID, pwd);

            setLastSentRequestExpectation(false, Request.RequestOneofCase.Logon);

            requestTask.Wait();

            assertSendRequestResult(requestTask);

            return stream;
        }

        private void waitResponse()
        {
            isResponded = false;

            while (!isResponded)
            {
                Thread.Sleep(3000);
            }
        }

        private void setLastSentRequestExpectation(bool hasError, Request.RequestOneofCase requestType, ERRORCODE resultCode = ERRORCODE.Success)
        {
            lastSentHasError = hasError;
            lastSentRequestType = requestType;
            lastSentRequestResultCode = resultCode;
        }

        private void assertSendRequestResult(Task<Tuple<Request, Response>> task)
        {
            if (lastSentHasError)
            {
                Assert.IsTrue(task.IsFaulted);
            }
            else
            {
                var pair = task.Result;

                var request = pair.Item1;
                var response = pair.Item2;

                Assert.AreEqual(lastSentRequestType, request.RequestCase);
                Assert.AreEqual(lastSentRequestResultCode, response.Result.ResultCode);
                Assert.AreEqual(request.RequestID, response.Result.Request);
            }
        }

        private void onNetworkError(Exception ex)
        {

        }

        private void onResponse(Response response)
        {

        }
    }
}
