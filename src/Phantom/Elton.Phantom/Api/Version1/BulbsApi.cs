#region License

//   Copyright 2014 Elton FAN (eltonfan@live.cn, http://elton.io)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Elton.Phantom.Models.Version1;
using Newtonsoft.Json;
using RestSharp;

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBulbsApi
    {
    }
}

namespace Elton.Phantom
{
    using Bulb = Models.Version1.Bulb;
    using Scenario = Models.Version1.Scenario;

    partial class PhantomApi : Api.Version1.IBulbsApi
    {
        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Bulb</returns>
        public Bulb[] GetBulbs()
        {
            return this.Get<Bulb[]>(1, "/bulbs");
        }
        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Bulb</returns>
        public async Task<Bulb[]> GetBulbsAsync()
        {
            return await this.GetAsync<Bulb[]>(1, "/bulbs");
        }

        /// <summary>
        /// 获取灯泡当前状态
        /// </summary>
        /// <remarks>
        /// 获取灯泡当前状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns></returns>
        public object GetBulbAdvance(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->GetBulbsAdvanceId");

            return Get<object>(1, $"/bulbs/advance/{id}");
        }

        /// <summary>
        /// 获取灯泡当前状态
        /// </summary>
        /// <remarks>
        /// 获取灯泡当前状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of void</returns>
        public async Task<object> GetBulbAdvanceAsync(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->GetBulbsAdvanceId");

            return await GetAsync<object>(1, $"/bulbs/advance/{id}");
        }

        /// <summary>
        /// 获取一天的使用情况的图表
        /// </summary>
        /// <remarks>
        /// 获取一天的使用情况的图表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="date">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.如果不传就是获取当日的意思 (optional)</param>
        /// <returns></returns>
        public object GetBulbsAdvanceIdChart(int? id, string date = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->GetBulbsAdvanceIdChart");

            return Get<object>(1, $"/bulbs/advance/{id}/chart",
                queryParams: new[]
                {
                     new KeyValuePair<string, string>("date", date),// query parameter
                });
        }

        /// <summary>
        /// 获取一天的使用情况的图表
        /// </summary>
        /// <remarks>
        /// 获取一天的使用情况的图表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="date">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.如果不传就是获取当日的意思 (optional)</param>
        /// <returns>Task of void</returns>
        public async Task<object> GetBulbsAdvanceIdChartAsync(int? id, string date = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->GetBulbsAdvanceIdChart");

            return await GetAsync<object>(1, $"/bulbs/advance/{id}/chart",
                queryParams: new[]
                {
                     new KeyValuePair<string, string>("date", date),// query parameter
                });
        }

        /// <summary>
        /// 获取灯泡的操作记录
        /// </summary>
        /// <remarks>
        /// 获取灯泡的操作记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="startDate">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.</param>
        /// <param name="endDate">格式同上，但是必须比start_date小；例如start_date是2016-7-4，那么end_date最大可以是2016-7-3。如果不传，则只返回start_date那一天的数据. (optional)</param>
        /// <returns></returns>
        public object GetBulbsAdvanceIdLogs(int? id, string startDate, string endDate = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->GetBulbsAdvanceIdLogs");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling BulbsApi->GetBulbsAdvanceIdLogs");

            return Get<object>(1, $"/bulbs/advance/{id}/logs",
                queryParams: new []
                {
                     new KeyValuePair<string, string>("start_date", startDate),// query parameter
                     new KeyValuePair<string, string>("end_date", endDate),// query parameter
                });
        }

        /// <summary>
        /// 获取灯泡的操作记录
        /// </summary>
        /// <remarks>
        /// 获取灯泡的操作记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="startDate">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.</param>
        /// <param name="endDate">格式同上，但是必须比start_date小；例如start_date是2016-7-4，那么end_date最大可以是2016-7-3。如果不传，则只返回start_date那一天的数据. (optional)</param>
        /// <returns>Task of void</returns>
        public async Task<object> GetBulbsAdvanceIdLogsAsync(int? id, string startDate, string endDate = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->GetBulbsAdvanceIdLogs");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling BulbsApi->GetBulbsAdvanceIdLogs");

            return await GetAsync<object>(1, $"/bulbs/advance/{id}/logs",
                queryParams: new[]
                {
                     new KeyValuePair<string, string>("start_date", startDate),// query parameter
                     new KeyValuePair<string, string>("end_date", endDate),// query parameter
                });
        }

        /// <summary>
        /// 获取了灯泡
        /// </summary>
        /// <remarks>
        /// 获取了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Bulb</returns>
        public Bulb GetBulb(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->GetBulbsId");

            return Get<Bulb>(1, $"/bulbs/{id}");
        }

        /// <summary>
        /// 获取了灯泡
        /// </summary>
        /// <remarks>
        /// 获取了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of Bulb</returns>
        public async Task<Bulb> GetBulbAsync(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->GetBulbsId");

            return await GetAsync<Bulb>(1, $"/bulbs/{id}");
        }

        /// <summary>
        /// 设定自动色温
        /// </summary>
        /// <remarks>
        /// 设定自动色温
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="autoHue">自动色温</param>
        /// <returns>OperationResult</returns>
        public OperationResult PostBulbAutoHue(int? id, bool? autoHue)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->PostBulbsIdAutoHue");
            // verify the required parameter 'autoHue' is set
            if (autoHue == null)
                throw new ApiException(400, "Missing required parameter 'autoHue' when calling BulbsApi->PostBulbsIdAutoHue");

            return Post<OperationResult>(1, $"/bulbs/{id}/auto_hue",
                new KeyValuePair<string, object>("auto_hue", autoHue));
        }

        /// <summary>
        /// 设定自动色温
        /// </summary>
        /// <remarks>
        /// 设定自动色温
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="autoHue">自动色温</param>
        /// <returns>Task of OperationResult</returns>
        public async Task<OperationResult> PostBulbAutoHueAsync(int? id, bool? autoHue)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->PostBulbsIdAutoHue");
            // verify the required parameter 'autoHue' is set
            if (autoHue == null)
                throw new ApiException(400, "Missing required parameter 'autoHue' when calling BulbsApi->PostBulbsIdAutoHue");

            return await PostAsync<OperationResult>(1, $"/bulbs/{id}/auto_hue",
                formParams: new[]
                {
                    new KeyValuePair<string, object>("auto_hue", autoHue),// form parameter
                });
        }

        /// <summary>
        /// 关闭了灯泡
        /// </summary>
        /// <remarks>
        /// 关闭了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>OperationResult</returns>
        public OperationResult PostBulbSwitchOff(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->PostBulbsIdSwitchOff");

            return Post<OperationResult>(1, $"/bulbs/{id}/switch_off");
        }

        /// <summary>
        /// 关闭了灯泡
        /// </summary>
        /// <remarks>
        /// 关闭了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of OperationResult</returns>
        public async Task<OperationResult> PostBulbSwitchOffAsync(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->PostBulbsIdSwitchOff");

            return await PostAsync<OperationResult>(1, $"/bulbs/{id}/switch_off");
        }

        /// <summary>
        /// 开启了灯泡
        /// </summary>
        /// <remarks>
        /// 开启了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>OperationResult</returns>
        public OperationResult PostBulbSwitchOn(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->PostBulbsIdSwitchOn");

            return Post<OperationResult>(1, $"/bulbs/{id}/switch_on");

        }

        /// <summary>
        /// 开启了灯泡
        /// </summary>
        /// <remarks>
        /// 开启了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of OperationResult</returns>
        public async Task<OperationResult> PostBulbSwitchOnAsync(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->PostBulbsIdSwitchOn");

            return await PostAsync<OperationResult>(1, $"/bulbs/{id}/switch_on");
        }

        /// <summary>
        /// 调节了灯泡的状态
        /// </summary>
        /// <remarks>
        /// 调节了灯泡的状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="brightness">亮度 (optional)</param>
        /// <param name="hue">色温 (optional)</param>
        /// <returns>OperationResult</returns>
        public OperationResult PostBulbTune(int? id, float? brightness = null, float? hue = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->PostBulbsIdTune");

            return Post<OperationResult>(1, $"/bulbs/{id}/tune",
                formParams: new[] {
                    new KeyValuePair<string, object>("brightness", brightness), // form parameter
                    new KeyValuePair<string, object>("hue", hue), // form parameter
                });
        }

        /// <summary>
        /// 调节了灯泡的状态
        /// </summary>
        /// <remarks>
        /// 调节了灯泡的状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="brightness">亮度 (optional)</param>
        /// <param name="hue">色温 (optional)</param>
        /// <returns>Task of OperationResult</returns>
        public async Task<OperationResult> PostBulbTuneAsync(int? id, float? brightness = null, float? hue = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BulbsApi->PostBulbsIdTune");

            return await PostAsync<OperationResult>(1, $"/bulbs/{id}/tune",
                formParams: new[] {
                    new KeyValuePair<string, object>("brightness", brightness), // form parameter
                    new KeyValuePair<string, object>("hue", hue), // form parameter
                });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hasDetails">如果为true，则同时获取详细信息。</param>
        /// <returns></returns>
        public Bulb[] GetBulbDetails()
        {
            Bulb[] arrayBulbs = this.Get<Bulb[]>(1, "bulbs");
            if (arrayBulbs == null || arrayBulbs.Length < 1)
                return arrayBulbs;

            var list = new List<Operation>();
            foreach (var item in arrayBulbs)
                list.Add(new Operation("GET", string.Format("/api/bulbs/{0}", item.Id)));

            var result = this.Batch(1, list.ToArray());
            var listDetails = new List<Bulb>();
            foreach (var item in result.Results)
            {
                if (item.Status == 200)
                {
                    var bulb = JsonConvert.DeserializeObject<Bulb>(item.Body);
                    listDetails.Add(bulb);
                }
            }
            return listDetails.ToArray();
        }
    }
}