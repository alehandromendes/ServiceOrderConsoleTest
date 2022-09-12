using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceOrderConsoleTest.Models
{
    public class ServiceOrders
    {
        [Key]
        [JsonProperty("totalExecutingActivities")]
        public int TotalExecutingActivities { get; set; }
        [JsonProperty("totalNewActivities")]
        public int TotalNewActivities { get; set; }
        [JsonProperty("totalPausedActivities")]
        public int TotalPausedActivities { get; set; }
        [JsonProperty("totalCancelledActivities")]
        public int TotalCancelledActivities { get; set; }
        [JsonProperty("totalClosedActivities")]
        public int TotalClosedActivities { get; set; }
        [JsonProperty("newSo")]
        public bool NewSo { get; set; }
        [JsonProperty("beginDate")]
        public DateTime beginDate { get; set; }
        [JsonProperty("defect")]
        public string Defect { get; set; }
        [JsonProperty("accountCode")]
        public string AccountCode { get; set; }
        [JsonProperty("personOpen")]
        public string PersonOpen { get; set; }
        [JsonProperty("account")]
        public string Account { get; set; }
        [JsonProperty("accountId")]
        public int AccountId { get; set; }
        [JsonProperty("sequentialId")]
        public int SequentialId { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("imported")]
        public bool Imported { get; set; }
        [JsonProperty("comments")]
        public List<comments> Comments { get; set; }
        [JsonProperty("accountOffset")]
        public int AccountOffset { get; set; }
        [JsonProperty("executingActivities")]
        public bool ExecutingActivities { get; set; }
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }
        [JsonProperty("personOpenId")]
        public int PersonOpenId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
    public class comments
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("id")]
        public int Id{ get; set; }
    }
}
