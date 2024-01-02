using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Immunity
{
    public partial class Immunity_panel : Form
    {
        public class Variables
        {
            public BackgroundWorker builder = new BackgroundWorker();
            public BackgroundWorker loader = new BackgroundWorker();
            public Manager.Threads manager = new Manager.Threads();
            public Dictionary<string, List<string>> dump = new Dictionary<string, List<string>>();
            public Popup.Wait waiter = new Popup.Wait();
            public Popup.Error select_all = new Popup.Error("Be careful some configuration settings will be in conflict");
            public Dictionary<string, Engine.Item> templates = new Dictionary<string, Engine.Item>()
            {
                { "Adaptive exposure: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.EyeAdaptationQuality, 0) },
                { "Adaptive exposure: enable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.EyeAdaptationQuality, 1) },

                { "Allow occlusion queries: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.AllowOcclusionQueries, 0) },
                { "Allow occlusion queries: enable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.AllowOcclusionQueries, 1) },
                
                { "Ambient occlusion: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.DefaultFeature_AmbientOcclusion, false) },
                { "Ambient occlusion: enable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.DefaultFeature_AmbientOcclusion, true) },
                
                { "Ambient occlusion levels: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.AmbientOcclusionLevels, 0) },
                { "Ambient occlusion levels: x1", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.AmbientOcclusionLevels, 1) },
                { "Ambient occlusion levels: x2", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.AmbientOcclusionLevels, 2) },
                { "Ambient occlusion levels: x3", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.AmbientOcclusionLevels, 3) },
                { "Ambient occlusion levels: x4", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.AmbientOcclusionLevels, 4) },
                
                { "Anisotropic filtering (AF): disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 0) },
                { "Anisotropic filtering (AF): x1", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 1) },
                { "Anisotropic filtering (AF): x2", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 2) },
                { "Anisotropic filtering (AF): x3", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 3) },
                { "Anisotropic filtering (AF): x4", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 4) },
                { "Anisotropic filtering (AF): x5", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 5) },
                { "Anisotropic filtering (AF): x6", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 6) },
                { "Anisotropic filtering (AF): x7", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 7) },
                { "Anisotropic filtering (AF): x8", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 8) },
                { "Anisotropic filtering (AF): x9", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 9) },
                { "Anisotropic filtering (AF): x10", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 10) },
                { "Anisotropic filtering (AF): x11", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 11) },
                { "Anisotropic filtering (AF): x12", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 12) },
                { "Anisotropic filtering (AF): x13", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 13) },
                { "Anisotropic filtering (AF): x14", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 14) },
                { "Anisotropic filtering (AF): x15", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 15) },
                { "Anisotropic filtering (AF): x16", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MaxAnisotropy, 16) },

                { "Anti-aliasing (AA): disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.PostProcessAAQuality, 0) },
                { "Anti-aliasing (AA): x1", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.PostProcessAAQuality, 1) },
                { "Anti-aliasing (AA): x2", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.PostProcessAAQuality, 2) },
                { "Anti-aliasing (AA): x3", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.PostProcessAAQuality, 3) },
                { "Anti-aliasing (AA): x4", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.PostProcessAAQuality, 4) },
                { "Anti-aliasing (AA): x5", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.PostProcessAAQuality, 5) },
                { "Anti-aliasing (AA): x6", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.PostProcessAAQuality, 6) },

                { "Anti-aliasing (FXAA): disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.DefaultFeature_AntiAliasing, 0) },
                { "Anti-aliasing (FXAA): enable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.DefaultFeature_AntiAliasing, 1) },

                { "Auto exposure: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.DefaultFeature_AutoExposure, false) },
                { "Auto exposure: enable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.DefaultFeature_AutoExposure, true) },

                { "Bloom quality: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.BloomQuality, 0) },
                { "Bloom quality: x1", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.BloomQuality, 1) },
                { "Bloom quality: x2", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.BloomQuality, 2) },
                { "Bloom quality: x3", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.BloomQuality, 3) },
                { "Bloom quality: x4", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.BloomQuality, 4) },
                { "Bloom quality: x5", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.BloomQuality, 5) },

                { "Chromatic aberration: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.SceneColorFringeQuality, 0) },
                { "Chromatic aberration: enable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.SceneColorFringeQuality, 1) },

                { "Depth of field: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.DepthOfFieldQuality, 0) },
                { "Depth of field: enable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.DepthOfFieldQuality, 1) },

                { "Early Z pass: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.EarlyZPass, 0) },
                { "Early Z pass: enable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.EarlyZPass, 1) },

                { "Early Z pass movable: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.EarlyZPassMovable, false) },
                { "Early Z pass movable: enable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.EarlyZPassMovable, true) },

                { "Film grain: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_GrainQuantization, 0) },
                { "Film grain: enable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_GrainQuantization, 1) },

                { "Fog: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Fog, 0) },
                { "Fog: enable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Fog, 1) },

                { "FOV scaling: native horizontal", new Engine.Item(Engine.Types.get(Engine.Types.local_player, true), Engine.Options.AspectRatioAxisConstraint, "AspectRatio_MaintainYFOV") },
                { "FOV scaling: native vertical", new Engine.Item(Engine.Types.get(Engine.Types.local_player, true), Engine.Options.AspectRatioAxisConstraint, "AspectRatio_MaintainXFOV") },

                { "Frame rate cap: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.MaxFPS, 0) },
                { "Frame rate cap: enable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.MaxFPS, 1) },

                { "Hierarchical Z-Buffer Occlusion (HZB): disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.HZBOcclusion, 0) },
                { "Hierarchical Z-Buffer Occlusion (HZB): enable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.HZBOcclusion, 1) },

                { "Image sharpening: 0%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 0.0) },
                { "Image sharpening: 10%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 1.0) },
                { "Image sharpening: 20%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 2.0) },
                { "Image sharpening: 30%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 3.0) },
                { "Image sharpening: 40%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 4.0) },
                { "Image sharpening: 50%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 5.0) },
                { "Image sharpening: 60%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 6.0) },
                { "Image sharpening: 70%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 7.0) },
                { "Image sharpening: 80%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 8.0) },
                { "Image sharpening: 90%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 9.0) },
                { "Image sharpening: 100%", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Sharpen, 10.0) },

                { "Lens flare: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.LensFlareQuality, 0) },
                { "Lens flare: enable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.LensFlareQuality, 1) },

                { "Motion blur: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.DefaultFeature_MotionBlur, 0) },
                { "Motion blur: enable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.DefaultFeature_MotionBlur, 1) },

                { "Motion blur quality: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MotionBlurQuality, 0) },
                { "Motion blur quality: x1", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MotionBlurQuality, 1) },
                { "Motion blur quality: x2", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MotionBlurQuality, 2) },
                { "Motion blur quality: x3", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MotionBlurQuality, 3) },
                { "Motion blur quality: x4", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.MotionBlurQuality, 4) },

                { "Reflection environment: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.ReflectionEnvironment, 0) },
                { "Reflection environment: blend with scene", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.ReflectionEnvironment, 1) },
                { "Reflection environment: overwrite scene", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.ReflectionEnvironment, 2) },

                { "Screen mod: borderless", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.FullScreenMode, 1) },
                { "Screen mod: fullscreen", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.FullScreenMode, 0) },

                { "Screen space ambient occlusion smart blur (SSAO): disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSAOSmartBlur, 0) },
                { "Screen space ambient occlusion smart blur (SSAO): enable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSAOSmartBlur, 1) },

                { "Screen space reflection quality (SSR): disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSR_Quality, 0) },
                { "Screen space reflection quality (SSR): enable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSR_Quality, 1) },
                
                { "Shadow max resolution: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.Shadow_MaxResolution, 0) },
                { "Shadow max resolution: x1", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.Shadow_MaxResolution, 128) },
                { "Shadow max resolution: x2", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.Shadow_MaxResolution, 512) },
                { "Shadow max resolution: x3", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.Shadow_MaxResolution, 1024) },
                { "Shadow max resolution: x4", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.Shadow_MaxResolution, 2048) },
                
                { "Shadow quality: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.ShadowQuality, false) },
                { "Shadow quality: enable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.ShadowQuality, true) },

                { "Smooth frame rate: disable", new Engine.Item(Engine.Types.get(Engine.Types.engine_engine, true), Engine.Options.bSmoothFrameRate, 0) },
                { "Smooth frame rate: enable", new Engine.Item(Engine.Types.get(Engine.Types.engine_engine, true), Engine.Options.bSmoothFrameRate, 1) },

                { "Subsurface scattering shading scale (SSS): disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 0) },
                { "Subsurface scattering shading scale (SSS): x1", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 1) },
                { "Subsurface scattering shading scale (SSS): x2", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 2) },
                { "Subsurface scattering shading scale (SSS): x3", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 3) },
                { "Subsurface scattering shading scale (SSS): x4", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 4) },
                { "Subsurface scattering shading scale (SSS): x5", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 5) },
                { "Subsurface scattering shading scale (SSS): x6", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 6) },
                { "Subsurface scattering shading scale (SSS): x7", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 7) },
                { "Subsurface scattering shading scale (SSS): x8", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 8) },
                { "Subsurface scattering shading scale (SSS): x9", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 8) },
                { "Subsurface scattering shading scale (SSS): x10", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.SSS_Scale, 10) },
                
                { "Tonemapping: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Quality, 0) },
                { "Tonemapping: x1", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Quality, 1) },
                { "Tonemapping: x2", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Quality, 2) },
                { "Tonemapping: x3", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Quality, 3) },
                { "Tonemapping: x4", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Quality, 4) },
                { "Tonemapping: x5", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.Tonemapper_Quality, 5) },

                { "True sky quality: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 0.0) },
                { "True sky quality: x1", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 0.1) },
                { "True sky quality: x2", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 0.2) },
                { "True sky quality: x3", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 0.3) },
                { "True sky quality: x4", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 0.4) },
                { "True sky quality: x5", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 0.5) },
                { "True sky quality: x6", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 0.6) },
                { "True sky quality: x7", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 0.7) },
                { "True sky quality: x8", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 0.8) },
                { "True sky quality: x9", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 0.9) },
                { "True sky quality: x10", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.TrueSkyQuality, 1) },

                { "Up sample quality: disable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.UpsampleQuality, 0) },
                { "Up sample quality: enable", new Engine.Item(Engine.Types.get(Engine.Types.renderer_settings, true), Engine.Options.UpsampleQuality, 1) },
                
                { "Vertical sync (Vsync): disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.VSync, 0) },
                { "Vertical sync (Vsync): enable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.VSync, 1) },
                
                { "View distance scale: disable", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 0) },
                { "View distance scale: x1", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 1) },
                { "View distance scale: x2", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 2) },
                { "View distance scale: x3", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 3) },
                { "View distance scale: x4", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 4) },
                { "View distance scale: x5", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 5) },
                { "View distance scale: x6", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 6) },
                { "View distance scale: x7", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 7) },
                { "View distance scale: x8", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 8) },
                { "View distance scale: x9", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 8) },
                { "View distance scale: x10", new Engine.Item(Engine.Types.get(Engine.Types.system_settings, false), Engine.Options.ViewDistanceScale, 10) },

                { "Verify peer: disable", new Engine.Item(Engine.Types.get(Engine.Types.engine_network_settings, true), Engine.Options.VerifyPeer, false) },
                { "Verify peer: enable", new Engine.Item(Engine.Types.get(Engine.Types.engine_network_settings, true), Engine.Options.VerifyPeer, true) }
            };
        }

        Variables variables = new Variables();

        public Immunity_panel()
        {
            InitializeComponent();
            InitializeUi();
            InitializeWorker();
        }

        private void InitializeWorker()
        {
            variables.builder.DoWork += new DoWorkEventHandler(build);
            variables.loader.DoWork += new DoWorkEventHandler(load);
        }

        private void InitializeUi()
        {
            Region = Region.FromHrgn(Manager.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            label_version.Text = Manager.Ui.version;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private Engine.Item templates(string value)
        {
            
            //r.DetailMode = 0
            //r.SSS.SampleS
            //r.LensFlareQuality = 0
            //r.oneframethreadlag = 1
            //r.simpledynamiclighting = 1
            //r.LightShaftQuality = 0
            //r.RefractionQuality = 0
            //r.ExposureOffset = 0.3

            return (variables.templates[value]);
        }

        private void load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Engine.Item> item in variables.templates)
            {
                variables.manager.add_checkedlistbox(checkboxes_modules, item.Key);
            }
        }

        public void worker(BackgroundWorker data)
        {
            data.RunWorkerAsync();

            while (data.IsBusy == true)
            {
                Application.DoEvents();
            }
        }
        
        private void button_build_Click(object sender, EventArgs e)
        {
            variables.manager.set_checkedlistbox(checkboxes_modules, false);
            variables.manager.button(button_build, false);

            worker(variables.builder);

            variables.manager.set_checkedlistbox(checkboxes_modules, true);
            variables.manager.button(button_build, true);
        }

        private void dump()
        {
            string date = DateTime.Now.ToString("hmmssddMMyyyy");
            List<string> data = stacker(variables.dump);

            File.WriteAllLines($"Engine_{date}.ini", data);
        }

        private void header()
        {
            List<string> content = new List<string>()
            {
                $"; Engine file generated by Immunity v{Manager.Ui.version}",
                "; Immunity author: Neo",
                "; All information in Elevatia's server",
            };

            variables.dump.Add("; Immunity", content);
        }

        private List<string> stacker(Dictionary<string, List<string>> data)
        {
            List<string> stacked = new List<string>();
            bool header = true;

            foreach (KeyValuePair<string, List<string>> item in data)
            {
                if (header == true)
                {
                    stacked.Add($"{item.Key}");
                    header = false;
                }
                else
                {
                    stacked.Add($"\n{item.Key}");
                }
                
                foreach (string element in item.Value)
                {
                    stacked.Add(element);
                }
            }

            return (stacked);
        }

        private void reset()
        {
            if (variables.dump.Count > 0)
                variables.dump.Clear();
            header();
        }

        private void build(object sender, EventArgs e)
        {
            CheckedListBox box = variables.manager.get_checkedlistbox(checkboxes_modules);
            Engine.Item item = null;
            List<string> list = null;
            string type = null;

            reset();
            foreach (string data in box.CheckedItems)
            {
                item = templates(data);
                type = $"[{item.type}]";
                if (variables.dump.ContainsKey(type) == true)
                {
                    list = variables.dump[type];
                    list.Add(build_option(item.option, item.value));
                    variables.dump[type] = list;
                }
                else
                {
                    list = new List<string>();
                    list.Add(build_option(item.option, item.value));
                    variables.dump.Add(type, list);
                }
            }
            dump();
        }

        private string build_option(string option, object value)
        {
            return ($"{option}={value}");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            variables.select_all.ShowDialog();
            for (int i = 0; i < checkboxes_modules.Items.Count; i++)
            {
                checkboxes_modules.SetItemChecked(i, true);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkboxes_modules.Items.Count; i++)
            {
                checkboxes_modules.SetItemChecked(i, false);
            }
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Immunity_Shown(object sender, EventArgs e)
        {
            worker(variables.loader);
        }
    }
}
