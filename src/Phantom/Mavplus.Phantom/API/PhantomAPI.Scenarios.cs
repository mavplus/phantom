﻿using Mavplus.Phantom.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.API
{
    partial class PhantomAPI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hasDetails">如果为true，则同时获取详细信息。</param>
        /// <returns></returns>
        public Scenario[] GetScenarios(bool hasDetails = false)
        {
            Scenario[] arrayScenarios = this.GET<Scenario[]>("scenarios.json");
            if (!hasDetails || arrayScenarios == null || arrayScenarios.Length < 1)
                return arrayScenarios;

            List<Operation> list = new List<Operation>();
            foreach (Scenario item in arrayScenarios)
                list.Add(new Operation("GET", string.Format("/api/scenarios/{0}.json", item.Id)));

            OperationResult[] results = this.Batch(list.ToArray());
            List<Scenario> listDetails = new List<Scenario>();
            foreach (OperationResult item in results)
            {
                if (item.Status == 200)
                {
                    Scenario Scenario = JsonConvert.DeserializeObject<Scenario>(item.Body);
                    listDetails.Add(Scenario);
                }
            }
            return listDetails.ToArray();
        }
        public Scenario GetScenario(int scenarioId)
        {
            return GET<Scenario>("scenarios/{id}.json", new UrlSegment("id", scenarioId.ToString()));
        }
        public void SetScenarioAllOn()
        {
            this.POST<Scenario>("scenarios/all_on.json", null, new Argument("origin", 1));
        }
        public void SetScenarioAllOff()
        {
            this.POST<Scenario>("scenarios/all_off.json", null, new Argument("origin", 1));
        }
        public void SetScenario(int scenarioId)
        {
            this.POST<Scenario>("scenarios/{id}/apply.json",
                new UrlSegment[] { new UrlSegment("id", scenarioId.ToString()) });
        }
    }
}
