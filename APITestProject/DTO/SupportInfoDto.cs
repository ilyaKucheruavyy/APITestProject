using Newtonsoft.Json;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace APITestProject.DTO;

public class SupportInfoDto
{
    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("text")] public string Text { get; set; }

    [JsonProperty("support")] public SupportInfoDto SupportInfo { get; set; }

    public override bool Equals(object obj) => this.Equals(obj as SupportInfoDto);

    public bool Equals(SupportInfoDto obj)
    {
        Assert.IsNotEmpty(obj.Url, "Url field is empty");
        Assert.IsNotEmpty(obj.Text, "Text field is empty");

        return true;
    }

    public SupportInfoDto GetSupportData(Table table)
    {
        var data = table.CreateInstance<SupportInfoDto>();
        this.SupportInfo = data;
        return this;
    }
}