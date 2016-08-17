using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilLib.ControlLib
{
    public static class UiLibWords
    {      
        public static List<string> BLOCK_PROPERTIES = new List<string>() {"_bcdx","_bcdy","_bposx","_bposy","_bposz","_brang","_brnd","_bvrndx",
                                                     "_bvrndy","_ht","_htr","_mcdx","_mcdy","_mposx","_mposy","_mrang","_mrnd",
                                                     "_tcdx","_tcdy","_tposx","_tposy","_trang","_trnd","_tvrndx","_tvrndy"};

        public const string PostFix = "FakeDB";
        public const string Spectrum = "Spectrum";
        public const string Data = "Data";
        public const string Input = "Input";
        public const string Output = "Output";

        public static string GetResultRootPath(string drivePath, string rootPath, long solutionId, string workItemId)
        {
            var rootDir = Path.Combine(drivePath, rootPath);
            var solPath = Path.Combine(rootDir, solutionId + @"\");
            var resultRootPath = Path.Combine(solPath, workItemId + @"\");

            return resultRootPath;
        }

        public static string GetGenerateResultPath(string genResultPath, long solutionId, string workItemId)
        {
            var solutionDir = genResultPath + solutionId + "/";
            var resultDir = solutionDir + workItemId + "/Result/";

            return resultDir;
        }

        public static string GetFFNNResultPath(long solutionId, string workItemId)
        {
            return solutionId + "/" + workItemId + "/Result/" + workItemId + ".result";
        }
    }
}
