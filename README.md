# Xceder
###Welcome to Xceder 
Xceder is designed for the high frequency and algo trading. It can route the order in millisecond level. In our live trading, we see almost all order process latency less than 10 milliseconds, many of them even just 1 millisecond. leverage on this speed edge, the spreader trading and algo trading is not just privilege from those big players.

To use Xceder is pretty simple, just download the Excel addin, open it in Microsoft Excel (2007 above). Here you go!

### Order Processing Speed
| Order Recieved Time(UTC) | Order Routed Time (UTC) | Latency (ms) |
| --- | --- | --- |
|	2016-10-03 15:03:41.086	|	2016-10-03 15:03:41.088	|	2	|
|	2016-10-03 15:02:47.120	|	2016-10-03 15:02:47.123	|	3	|
|	2016-10-03 15:02:29.526	|	2016-10-03 15:02:29.528	|	2	|
|	2016-10-03 15:01:58.227	|	2016-10-03 15:01:58.382	|	155	|
|	2016-10-03 13:20:44.263	|	2016-10-03 13:20:44.288	|	25	|
|	2016-10-03 13:20:28.384	|	2016-10-03 13:20:28.467	|	83	|
|	2016-10-03 11:12:13.963	|	2016-10-03 11:12:13.968	|	5	|
|	2016-10-03 11:12:04.963	|	2016-10-03 11:12:05.051	|	88	|
|	2016-10-03 11:05:28.046	|	2016-10-03 11:05:28.049	|	3	|
|	2016-10-03 11:03:29.742	|	2016-10-03 11:03:29.743	|	1	|
|	2016-10-03 11:02:58.053	|	2016-10-03 11:02:58.053	|	0	|
|	2016-10-03 11:02:39.517	|	2016-10-03 11:02:39.520	|	3	|
|	2016-10-03 11:01:24.908	|	2016-10-03 11:01:24.921	|	13	|
|	2016-10-03 11:00:26.115	|	2016-10-03 11:00:26.118	|	3	|
|	2016-10-03 10:59:49.532	|	2016-10-03 10:59:49.533	|	1	|
|	2016-10-03 10:59:02.173	|	2016-10-03 10:59:02.257	|	84	|
|	2016-10-03 10:56:23.918	|	2016-10-03 10:56:23.951	|	33	|
|	2016-10-03 10:31:49.248	|	2016-10-03 10:31:49.264	|	16	|
|	2016-10-03 10:30:12.688	|	2016-10-03 10:30:12.694	|	6	|
|	2016-10-03 10:15:34.353	|	2016-10-03 10:15:34.389	|	36	|
|	2016-10-03 10:04:21.349	|	2016-10-03 10:04:21.351	|	2	|
|	2016-10-03 09:59:59.225	|	2016-10-03 09:59:59.227	|	2	|
|	2016-10-03 09:55:04.148	|	2016-10-03 09:55:04.150	|	2	|
|	2016-10-03 09:53:00.795	|	2016-10-03 09:53:00.795	|	0	|
|	2016-10-03 09:52:32.657	|	2016-10-03 09:52:32.658	|	1	|
|	2016-10-03 09:51:53.961	|	2016-10-03 09:51:53.963	|	2	|
|	2016-10-03 09:51:11.930	|	2016-10-03 09:51:11.931	|	1	|
|	2016-10-03 09:50:59.796	|	2016-10-03 09:50:59.797	|	1	|
|	2016-10-03 09:50:30.570	|	2016-10-03 09:50:30.572	|	2	|
|	2016-10-03 09:50:03.258	|	2016-10-03 09:50:03.274	|	16	|
|	2016-10-03 09:49:49.527	|	2016-10-03 09:49:49.529	|	2	|
|	2016-10-03 09:48:09.061	|	2016-10-03 09:48:09.070	|	9	|
|	2016-10-03 09:46:01.930	|	2016-10-03 09:46:01.987	|	57	|
|	2016-10-03 09:40:00.661	|	2016-10-03 09:40:00.667	|	6	|
|	2016-10-03 09:39:19.407	|	2016-10-03 09:39:19.412	|	5	|
|	2016-10-03 09:37:46.656	|	2016-10-03 09:37:46.657	|	1	|
|	2016-10-03 09:36:43.010	|	2016-10-03 09:36:43.013	|	3	|
|	2016-10-03 09:35:56.303	|	2016-10-03 09:35:56.313	|	10	|
|	2016-10-03 09:31:12.031	|	2016-10-03 09:31:12.031	|	0	|
|	2016-10-03 09:30:19.998	|	2016-10-03 09:30:19.999	|	1	|
|	2016-10-03 09:30:02.781	|	2016-10-03 09:30:02.806	|	25	|
|	2016-10-03 09:17:58.016	|	2016-10-03 09:17:58.214	|	198	|
|	2016-10-03 08:02:18.041	|	2016-10-03 08:02:18.045	|	4	|
|	2016-10-03 08:02:08.701	|	2016-10-03 08:02:08.728	|	27	|
|	2016-10-03 08:02:00.642	|	2016-10-03 08:02:00.651	|	9	|
|	2016-10-03 08:01:03.101	|	2016-10-03 08:01:03.115	|	14	|
|	2016-10-03 07:57:32.465	|	2016-10-03 07:57:32.573	|	108	|
|	2016-10-03 07:56:01.418	|	2016-10-03 07:56:01.423	|	5	|
|	2016-10-03 07:53:00.164	|	2016-10-03 07:53:00.196	|	32	|
|	2016-10-03 07:51:24.573	|	2016-10-03 07:51:24.596	|	23	|


### Tutorial

Get started using this step by step [tutorial](https://github.com/DT-Workshop/Xceder/wiki/).

### To use Xceder

Just download and open [Xceder](https://github.com/DT-Workshop/Xceder/releases/) in Excel (2007 above). 

*For 64bit Excel, you need open the file which name contains '64'*

### Running Environment

* Excel 2007 above 

### Versions

[Change Log](changelog.md)

0.x release: [0.9.9.8](https://github.com/DT-Workshop/Xceder/releases)

@Copyright 2016 [dt-workshop](http://www.dt-workshop.com)



