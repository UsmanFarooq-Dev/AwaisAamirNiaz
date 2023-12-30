using AwaisAamirNiaz.Blazor.Database;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace AwaisAamirNiaz.Blazor.Components.Pages;

public partial class Disease
{
    private string _pageTile = "Rana Khoti";
    private IList<DiseaseModel> diseases;
    [Inject] IOptions<ConnectionStringModel> settings { get; set; }
    [Inject] IWebHostEnvironment environment { get; set; }
    private IWebHostEnvironment _env;

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(500);
        var conString = settings.Value.ConnectionString;
        diseases = DataAccess.GetDiseases(conString);

        //_env = env;
        //Helper.InitializeFolders(_env.ContentRootPath);
        //filesRootPath  = Path.Combine(_env.ContentRootPath, "Data", "Files");
        //LoadNodes();
    }

}
