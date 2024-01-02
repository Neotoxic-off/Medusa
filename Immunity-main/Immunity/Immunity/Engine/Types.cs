using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immunity.Engine
{
    public class Types
    {
        public static string local_player = "engine.localplayer";
        public static string system_settings = "systemsettings";
        public static string engine_engine = "engine.engine";
        public static string renderer_settings = "engine.renderersettings";
        public static string engine_network_settings = "engine.networksettings";
        public static string script = "/script/";

        private static Dictionary<string, string> data = new Dictionary<string, string>()
        {
            { "engine.localplayer", local_player },
            { "systemsettings", system_settings },
            { "engine.engine", engine_engine },
            { "engine.renderersettings", renderer_settings },
            { "engine.networksettings", engine_network_settings },
            { "script", script }
        };

        public static string get(string value, bool script)
        {
            string configuration = "";

            if (script == true)
            {
                configuration = data["script"];
            }
            configuration += data[value];

            return (configuration);
        }
    }

    public class Options
    {
        public static string AspectRatioAxisConstraint = "AspectRatioAxisConstraint";
        public static string FullScreenMode = "r.FullScreenMode";
        public static string PostProcessAAQuality = "r.PostProcessAAQuality";
        public static string VerifyPeer = "n.VerifyPeer";
        public static string DefaultFeature_AntiAliasing = "r.DefaultFeature.AntiAliasing";
        public static string Tonemapper_Sharpen = "r.Tonemapper.Sharpen";
        public static string MaxAnisotropy = "r.MaxAnisotropy";
        public static string VSync = "r.VSync";
        public static string bSmoothFrameRate = "bSmoothFrameRate";
        public static string MaxFPS = "t.MaxFPS";
        public static string EyeAdaptationQuality = "r.EyeAdaptationQuality";
        public static string SceneColorFringeQuality = "r.SceneColorFringeQuality";
        public static string DepthOfFieldQuality = "r.DepthOfFieldQuality";
        public static string Tonemapper_GrainQuantization = "r.Tonemapper.GrainQuantization";
        public static string LensFlareQuality = "r.LensFlareQuality";
        public static string Tonemapper_Quality = "r.Tonemapper.Quality";
        public static string DefaultFeature_MotionBlur = "r.DefaultFeature.MotionBlur";
        public static string MotionBlurQuality = "r.MotionBlurQuality";
        public static string AllowOcclusionQueries = "r.AllowOcclusionQueries";
        public static string ViewDistanceScale = "r.ViewDistanceScale";
        public static string Fog = "r.Fog";
        public static string ShadowQuality = "r.ShadowQuality";
        public static string DefaultFeature_AmbientOcclusion = "r.DefaultFeature.AmbientOcclusion";
        public static string DefaultFeature_AutoExposure = "r.DefaultFeature.AutoExposure";
        public static string EarlyZPass = "r.EarlyZPass";
        public static string EarlyZPassMovable = "r.EarlyZPassMovable";
        public static string SSAOSmartBlur = "r.SSAOSmartBlur";
        public static string HZBOcclusion = "r.HZBOcclusion";
        public static string AmbientOcclusionLevels = "r.AmbientOcclusionLevels";
        public static string BloomQuality = "r.BloomQuality";
        public static string SSR_Quality = "r.SSR.Quality";
        public static string SSS_Scale = "r.SSS.Scale";
        public static string TrueSkyQuality = "r.TrueSkyQuality";
        public static string UpsampleQuality = "r.UpsampleQuality";
        public static string Shadow_MaxResolution = "r.Shadow.MaxResolution";
        public static string ReflectionEnvironment = "r.ReflectionEnvironment";
    }
}
