
using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities; 
  
namespace FTVSToolKit { //AA   

    internal static class AllColorsDefinition { // DiffClassificationDefinitions
	 
                    
            /* -- AliceBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.aliceblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffAliceBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.aliceblue")]
            [Name("text.aliceblue")]
            internal sealed class DiffAliceBlueFormat : ClassificationFormatDefinition{

                public DiffAliceBlueFormat() { 
					this.ForegroundColor = Colors.AliceBlue; 
				}
            }
                    
            /* -- AntiqueWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.antiquewhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffAntiqueWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.antiquewhite")]
            [Name("text.antiquewhite")]
            internal sealed class DiffAntiqueWhiteFormat : ClassificationFormatDefinition{

                public DiffAntiqueWhiteFormat() { 
					this.ForegroundColor = Colors.AntiqueWhite; 
				}
            }
                    
            /* -- Aqua --------------------------------------------------------  */
            [Export][Name("coloredtext.aqua")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffAquaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.aqua")]
            [Name("text.aqua")]
            internal sealed class DiffAquaFormat : ClassificationFormatDefinition{

                public DiffAquaFormat() { 
					this.ForegroundColor = Colors.Aqua; 
				}
            }
                    
            /* -- Aquamarine --------------------------------------------------------  */
            [Export][Name("coloredtext.aquamarine")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffAquamarineDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.aquamarine")]
            [Name("text.aquamarine")]
            internal sealed class DiffAquamarineFormat : ClassificationFormatDefinition{

                public DiffAquamarineFormat() { 
					this.ForegroundColor = Colors.Aquamarine; 
				}
            }
                    
            /* -- Azure --------------------------------------------------------  */
            [Export][Name("coloredtext.azure")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffAzureDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.azure")]
            [Name("text.azure")]
            internal sealed class DiffAzureFormat : ClassificationFormatDefinition{

                public DiffAzureFormat() { 
					this.ForegroundColor = Colors.Azure; 
				}
            }
                    
            /* -- Beige --------------------------------------------------------  */
            [Export][Name("coloredtext.beige")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffBeigeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.beige")]
            [Name("text.beige")]
            internal sealed class DiffBeigeFormat : ClassificationFormatDefinition{

                public DiffBeigeFormat() { 
					this.ForegroundColor = Colors.Beige; 
				}
            }
                    
            /* -- Bisque --------------------------------------------------------  */
            [Export][Name("coloredtext.bisque")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffBisqueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bisque")]
            [Name("text.bisque")]
            internal sealed class DiffBisqueFormat : ClassificationFormatDefinition{

                public DiffBisqueFormat() { 
					this.ForegroundColor = Colors.Bisque; 
				}
            }
                    
            /* -- Black --------------------------------------------------------  */
            [Export][Name("coloredtext.black")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffBlackDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.black")]
            [Name("text.black")]
            internal sealed class DiffBlackFormat : ClassificationFormatDefinition{

                public DiffBlackFormat() { 
					this.ForegroundColor = Colors.Black; 
				}
            }
                    
            /* -- BlanchedAlmond --------------------------------------------------------  */
            [Export][Name("coloredtext.blanchedalmond")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffBlanchedAlmondDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.blanchedalmond")]
            [Name("text.blanchedalmond")]
            internal sealed class DiffBlanchedAlmondFormat : ClassificationFormatDefinition{

                public DiffBlanchedAlmondFormat() { 
					this.ForegroundColor = Colors.BlanchedAlmond; 
				}
            }
                    
            /* -- Blue --------------------------------------------------------  */
            [Export][Name("coloredtext.blue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.blue")]
            [Name("text.blue")]
            internal sealed class DiffBlueFormat : ClassificationFormatDefinition{

                public DiffBlueFormat() { 
					this.ForegroundColor = Colors.Blue; 
				}
            }
                    
            /* -- BlueViolet --------------------------------------------------------  */
            [Export][Name("coloredtext.blueviolet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffBlueVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.blueviolet")]
            [Name("text.blueviolet")]
            internal sealed class DiffBlueVioletFormat : ClassificationFormatDefinition{

                public DiffBlueVioletFormat() { 
					this.ForegroundColor = Colors.BlueViolet; 
				}
            }
                    
            /* -- Brown --------------------------------------------------------  */
            [Export][Name("coloredtext.brown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.brown")]
            [Name("text.brown")]
            internal sealed class DiffBrownFormat : ClassificationFormatDefinition{

                public DiffBrownFormat() { 
					this.ForegroundColor = Colors.Brown; 
				}
            }
                    
            /* -- BurlyWood --------------------------------------------------------  */
            [Export][Name("coloredtext.burlywood")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffBurlyWoodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.burlywood")]
            [Name("text.burlywood")]
            internal sealed class DiffBurlyWoodFormat : ClassificationFormatDefinition{

                public DiffBurlyWoodFormat() { 
					this.ForegroundColor = Colors.BurlyWood; 
				}
            }
                    
            /* -- CadetBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.cadetblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffCadetBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.cadetblue")]
            [Name("text.cadetblue")]
            internal sealed class DiffCadetBlueFormat : ClassificationFormatDefinition{

                public DiffCadetBlueFormat() { 
					this.ForegroundColor = Colors.CadetBlue; 
				}
            }
                    
            /* -- Chartreuse --------------------------------------------------------  */
            [Export][Name("coloredtext.chartreuse")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffChartreuseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.chartreuse")]
            [Name("text.chartreuse")]
            internal sealed class DiffChartreuseFormat : ClassificationFormatDefinition{

                public DiffChartreuseFormat() { 
					this.ForegroundColor = Colors.Chartreuse; 
				}
            }
                    
            /* -- Chocolate --------------------------------------------------------  */
            [Export][Name("coloredtext.chocolate")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffChocolateDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.chocolate")]
            [Name("text.chocolate")]
            internal sealed class DiffChocolateFormat : ClassificationFormatDefinition{

                public DiffChocolateFormat() { 
					this.ForegroundColor = Colors.Chocolate; 
				}
            }
                    
            /* -- Coral --------------------------------------------------------  */
            [Export][Name("coloredtext.coral")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffCoralDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.coral")]
            [Name("text.coral")]
            internal sealed class DiffCoralFormat : ClassificationFormatDefinition{

                public DiffCoralFormat() { 
					this.ForegroundColor = Colors.Coral; 
				}
            }
                    
            /* -- CornflowerBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.cornflowerblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffCornflowerBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.cornflowerblue")]
            [Name("text.cornflowerblue")]
            internal sealed class DiffCornflowerBlueFormat : ClassificationFormatDefinition{

                public DiffCornflowerBlueFormat() { 
					this.ForegroundColor = Colors.CornflowerBlue; 
				}
            }
                    
            /* -- Cornsilk --------------------------------------------------------  */
            [Export][Name("coloredtext.cornsilk")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffCornsilkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.cornsilk")]
            [Name("text.cornsilk")]
            internal sealed class DiffCornsilkFormat : ClassificationFormatDefinition{

                public DiffCornsilkFormat() { 
					this.ForegroundColor = Colors.Cornsilk; 
				}
            }
                    
            /* -- Crimson --------------------------------------------------------  */
            [Export][Name("coloredtext.crimson")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffCrimsonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.crimson")]
            [Name("text.crimson")]
            internal sealed class DiffCrimsonFormat : ClassificationFormatDefinition{

                public DiffCrimsonFormat() { 
					this.ForegroundColor = Colors.Crimson; 
				}
            }
                    
            /* -- Cyan --------------------------------------------------------  */
            [Export][Name("coloredtext.cyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.cyan")]
            [Name("text.cyan")]
            internal sealed class DiffCyanFormat : ClassificationFormatDefinition{

                public DiffCyanFormat() { 
					this.ForegroundColor = Colors.Cyan; 
				}
            }
                    
            /* -- DarkBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.darkblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkblue")]
            [Name("text.darkblue")]
            internal sealed class DiffDarkBlueFormat : ClassificationFormatDefinition{

                public DiffDarkBlueFormat() { 
					this.ForegroundColor = Colors.DarkBlue; 
				}
            }
                    
            /* -- DarkCyan --------------------------------------------------------  */
            [Export][Name("coloredtext.darkcyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkcyan")]
            [Name("text.darkcyan")]
            internal sealed class DiffDarkCyanFormat : ClassificationFormatDefinition{

                public DiffDarkCyanFormat() { 
					this.ForegroundColor = Colors.DarkCyan; 
				}
            }
                    
            /* -- DarkGoldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.darkgoldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkgoldenrod")]
            [Name("text.darkgoldenrod")]
            internal sealed class DiffDarkGoldenrodFormat : ClassificationFormatDefinition{

                public DiffDarkGoldenrodFormat() { 
					this.ForegroundColor = Colors.DarkGoldenrod; 
				}
            }
                    
            /* -- DarkGray --------------------------------------------------------  */
            [Export][Name("coloredtext.darkgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkgray")]
            [Name("text.darkgray")]
            internal sealed class DiffDarkGrayFormat : ClassificationFormatDefinition{

                public DiffDarkGrayFormat() { 
					this.ForegroundColor = Colors.DarkGray; 
				}
            }
                    
            /* -- DarkGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.darkgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkgreen")]
            [Name("text.darkgreen")]
            internal sealed class DiffDarkGreenFormat : ClassificationFormatDefinition{

                public DiffDarkGreenFormat() { 
					this.ForegroundColor = Colors.DarkGreen; 
				}
            }
                    
            /* -- DarkKhaki --------------------------------------------------------  */
            [Export][Name("coloredtext.darkkhaki")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkKhakiDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkkhaki")]
            [Name("text.darkkhaki")]
            internal sealed class DiffDarkKhakiFormat : ClassificationFormatDefinition{

                public DiffDarkKhakiFormat() { 
					this.ForegroundColor = Colors.DarkKhaki; 
				}
            }
                    
            /* -- DarkMagenta --------------------------------------------------------  */
            [Export][Name("coloredtext.darkmagenta")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkMagentaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkmagenta")]
            [Name("text.darkmagenta")]
            internal sealed class DiffDarkMagentaFormat : ClassificationFormatDefinition{

                public DiffDarkMagentaFormat() { 
					this.ForegroundColor = Colors.DarkMagenta; 
				}
            }
                    
            /* -- DarkOliveGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.darkolivegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkOliveGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkolivegreen")]
            [Name("text.darkolivegreen")]
            internal sealed class DiffDarkOliveGreenFormat : ClassificationFormatDefinition{

                public DiffDarkOliveGreenFormat() { 
					this.ForegroundColor = Colors.DarkOliveGreen; 
				}
            }
                    
            /* -- DarkOrange --------------------------------------------------------  */
            [Export][Name("coloredtext.darkorange")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkOrangeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkorange")]
            [Name("text.darkorange")]
            internal sealed class DiffDarkOrangeFormat : ClassificationFormatDefinition{

                public DiffDarkOrangeFormat() { 
					this.ForegroundColor = Colors.DarkOrange; 
				}
            }
                    
            /* -- DarkOrchid --------------------------------------------------------  */
            [Export][Name("coloredtext.darkorchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkorchid")]
            [Name("text.darkorchid")]
            internal sealed class DiffDarkOrchidFormat : ClassificationFormatDefinition{

                public DiffDarkOrchidFormat() { 
					this.ForegroundColor = Colors.DarkOrchid; 
				}
            }
                    
            /* -- DarkRed --------------------------------------------------------  */
            [Export][Name("coloredtext.darkred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkred")]
            [Name("text.darkred")]
            internal sealed class DiffDarkRedFormat : ClassificationFormatDefinition{

                public DiffDarkRedFormat() { 
					this.ForegroundColor = Colors.DarkRed; 
				}
            }
                    
            /* -- DarkSalmon --------------------------------------------------------  */
            [Export][Name("coloredtext.darksalmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darksalmon")]
            [Name("text.darksalmon")]
            internal sealed class DiffDarkSalmonFormat : ClassificationFormatDefinition{

                public DiffDarkSalmonFormat() { 
					this.ForegroundColor = Colors.DarkSalmon; 
				}
            }
                    
            /* -- DarkSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.darkseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkseagreen")]
            [Name("text.darkseagreen")]
            internal sealed class DiffDarkSeaGreenFormat : ClassificationFormatDefinition{

                public DiffDarkSeaGreenFormat() { 
					this.ForegroundColor = Colors.DarkSeaGreen; 
				}
            }
                    
            /* -- DarkSlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.darkslateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkslateblue")]
            [Name("text.darkslateblue")]
            internal sealed class DiffDarkSlateBlueFormat : ClassificationFormatDefinition{

                public DiffDarkSlateBlueFormat() { 
					this.ForegroundColor = Colors.DarkSlateBlue; 
				}
            }
                    
            /* -- DarkSlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.darkslategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkslategray")]
            [Name("text.darkslategray")]
            internal sealed class DiffDarkSlateGrayFormat : ClassificationFormatDefinition{

                public DiffDarkSlateGrayFormat() { 
					this.ForegroundColor = Colors.DarkSlateGray; 
				}
            }
                    
            /* -- DarkTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.darkturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkturquoise")]
            [Name("text.darkturquoise")]
            internal sealed class DiffDarkTurquoiseFormat : ClassificationFormatDefinition{

                public DiffDarkTurquoiseFormat() { 
					this.ForegroundColor = Colors.DarkTurquoise; 
				}
            }
                    
            /* -- DarkViolet --------------------------------------------------------  */
            [Export][Name("coloredtext.darkviolet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDarkVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.darkviolet")]
            [Name("text.darkviolet")]
            internal sealed class DiffDarkVioletFormat : ClassificationFormatDefinition{

                public DiffDarkVioletFormat() { 
					this.ForegroundColor = Colors.DarkViolet; 
				}
            }
                    
            /* -- DeepPink --------------------------------------------------------  */
            [Export][Name("coloredtext.deeppink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDeepPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.deeppink")]
            [Name("text.deeppink")]
            internal sealed class DiffDeepPinkFormat : ClassificationFormatDefinition{

                public DiffDeepPinkFormat() { 
					this.ForegroundColor = Colors.DeepPink; 
				}
            }
                    
            /* -- DeepSkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.deepskyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDeepSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.deepskyblue")]
            [Name("text.deepskyblue")]
            internal sealed class DiffDeepSkyBlueFormat : ClassificationFormatDefinition{

                public DiffDeepSkyBlueFormat() { 
					this.ForegroundColor = Colors.DeepSkyBlue; 
				}
            }
                    
            /* -- DimGray --------------------------------------------------------  */
            [Export][Name("coloredtext.dimgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDimGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.dimgray")]
            [Name("text.dimgray")]
            internal sealed class DiffDimGrayFormat : ClassificationFormatDefinition{

                public DiffDimGrayFormat() { 
					this.ForegroundColor = Colors.DimGray; 
				}
            }
                    
            /* -- DodgerBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.dodgerblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffDodgerBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.dodgerblue")]
            [Name("text.dodgerblue")]
            internal sealed class DiffDodgerBlueFormat : ClassificationFormatDefinition{

                public DiffDodgerBlueFormat() { 
					this.ForegroundColor = Colors.DodgerBlue; 
				}
            }
                    
            /* -- Firebrick --------------------------------------------------------  */
            [Export][Name("coloredtext.firebrick")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffFirebrickDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.firebrick")]
            [Name("text.firebrick")]
            internal sealed class DiffFirebrickFormat : ClassificationFormatDefinition{

                public DiffFirebrickFormat() { 
					this.ForegroundColor = Colors.Firebrick; 
				}
            }
                    
            /* -- FloralWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.floralwhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffFloralWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.floralwhite")]
            [Name("text.floralwhite")]
            internal sealed class DiffFloralWhiteFormat : ClassificationFormatDefinition{

                public DiffFloralWhiteFormat() { 
					this.ForegroundColor = Colors.FloralWhite; 
				}
            }
                    
            /* -- ForestGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.forestgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffForestGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.forestgreen")]
            [Name("text.forestgreen")]
            internal sealed class DiffForestGreenFormat : ClassificationFormatDefinition{

                public DiffForestGreenFormat() { 
					this.ForegroundColor = Colors.ForestGreen; 
				}
            }
                    
            /* -- Fuchsia --------------------------------------------------------  */
            [Export][Name("coloredtext.fuchsia")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffFuchsiaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.fuchsia")]
            [Name("text.fuchsia")]
            internal sealed class DiffFuchsiaFormat : ClassificationFormatDefinition{

                public DiffFuchsiaFormat() { 
					this.ForegroundColor = Colors.Fuchsia; 
				}
            }
                    
            /* -- Gainsboro --------------------------------------------------------  */
            [Export][Name("coloredtext.gainsboro")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffGainsboroDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.gainsboro")]
            [Name("text.gainsboro")]
            internal sealed class DiffGainsboroFormat : ClassificationFormatDefinition{

                public DiffGainsboroFormat() { 
					this.ForegroundColor = Colors.Gainsboro; 
				}
            }
                    
            /* -- GhostWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.ghostwhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffGhostWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.ghostwhite")]
            [Name("text.ghostwhite")]
            internal sealed class DiffGhostWhiteFormat : ClassificationFormatDefinition{

                public DiffGhostWhiteFormat() { 
					this.ForegroundColor = Colors.GhostWhite; 
				}
            }
                    
            /* -- Gold --------------------------------------------------------  */
            [Export][Name("coloredtext.gold")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffGoldDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.gold")]
            [Name("text.gold")]
            internal sealed class DiffGoldFormat : ClassificationFormatDefinition{

                public DiffGoldFormat() { 
					this.ForegroundColor = Colors.Gold; 
				}
            }
                    
            /* -- Goldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.goldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.goldenrod")]
            [Name("text.goldenrod")]
            internal sealed class DiffGoldenrodFormat : ClassificationFormatDefinition{

                public DiffGoldenrodFormat() { 
					this.ForegroundColor = Colors.Goldenrod; 
				}
            }
                    
            /* -- Gray --------------------------------------------------------  */
            [Export][Name("coloredtext.gray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.gray")]
            [Name("text.gray")]
            internal sealed class DiffGrayFormat : ClassificationFormatDefinition{

                public DiffGrayFormat() { 
					this.ForegroundColor = Colors.Gray; 
				}
            }
                    
            /* -- Green --------------------------------------------------------  */
            [Export][Name("coloredtext.green")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.green")]
            [Name("text.green")]
            internal sealed class DiffGreenFormat : ClassificationFormatDefinition{

                public DiffGreenFormat() { 
					this.ForegroundColor = Colors.Green; 
				}
            }
                    
            /* -- GreenYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.greenyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffGreenYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.greenyellow")]
            [Name("text.greenyellow")]
            internal sealed class DiffGreenYellowFormat : ClassificationFormatDefinition{

                public DiffGreenYellowFormat() { 
					this.ForegroundColor = Colors.GreenYellow; 
				}
            }
                    
            /* -- Honeydew --------------------------------------------------------  */
            [Export][Name("coloredtext.honeydew")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffHoneydewDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.honeydew")]
            [Name("text.honeydew")]
            internal sealed class DiffHoneydewFormat : ClassificationFormatDefinition{

                public DiffHoneydewFormat() { 
					this.ForegroundColor = Colors.Honeydew; 
				}
            }
                    
            /* -- HotPink --------------------------------------------------------  */
            [Export][Name("coloredtext.hotpink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffHotPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.hotpink")]
            [Name("text.hotpink")]
            internal sealed class DiffHotPinkFormat : ClassificationFormatDefinition{

                public DiffHotPinkFormat() { 
					this.ForegroundColor = Colors.HotPink; 
				}
            }
                    
            /* -- IndianRed --------------------------------------------------------  */
            [Export][Name("coloredtext.indianred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffIndianRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.indianred")]
            [Name("text.indianred")]
            internal sealed class DiffIndianRedFormat : ClassificationFormatDefinition{

                public DiffIndianRedFormat() { 
					this.ForegroundColor = Colors.IndianRed; 
				}
            }
                    
            /* -- Indigo --------------------------------------------------------  */
            [Export][Name("coloredtext.indigo")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffIndigoDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.indigo")]
            [Name("text.indigo")]
            internal sealed class DiffIndigoFormat : ClassificationFormatDefinition{

                public DiffIndigoFormat() { 
					this.ForegroundColor = Colors.Indigo; 
				}
            }
                    
            /* -- Ivory --------------------------------------------------------  */
            [Export][Name("coloredtext.ivory")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffIvoryDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.ivory")]
            [Name("text.ivory")]
            internal sealed class DiffIvoryFormat : ClassificationFormatDefinition{

                public DiffIvoryFormat() { 
					this.ForegroundColor = Colors.Ivory; 
				}
            }
                    
            /* -- Khaki --------------------------------------------------------  */
            [Export][Name("coloredtext.khaki")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffKhakiDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.khaki")]
            [Name("text.khaki")]
            internal sealed class DiffKhakiFormat : ClassificationFormatDefinition{

                public DiffKhakiFormat() { 
					this.ForegroundColor = Colors.Khaki; 
				}
            }
                    
            /* -- Lavender --------------------------------------------------------  */
            [Export][Name("coloredtext.lavender")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLavenderDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lavender")]
            [Name("text.lavender")]
            internal sealed class DiffLavenderFormat : ClassificationFormatDefinition{

                public DiffLavenderFormat() { 
					this.ForegroundColor = Colors.Lavender; 
				}
            }
                    
            /* -- LavenderBlush --------------------------------------------------------  */
            [Export][Name("coloredtext.lavenderblush")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLavenderBlushDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lavenderblush")]
            [Name("text.lavenderblush")]
            internal sealed class DiffLavenderBlushFormat : ClassificationFormatDefinition{

                public DiffLavenderBlushFormat() { 
					this.ForegroundColor = Colors.LavenderBlush; 
				}
            }
                    
            /* -- LawnGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.lawngreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLawnGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lawngreen")]
            [Name("text.lawngreen")]
            internal sealed class DiffLawnGreenFormat : ClassificationFormatDefinition{

                public DiffLawnGreenFormat() { 
					this.ForegroundColor = Colors.LawnGreen; 
				}
            }
                    
            /* -- LemonChiffon --------------------------------------------------------  */
            [Export][Name("coloredtext.lemonchiffon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLemonChiffonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lemonchiffon")]
            [Name("text.lemonchiffon")]
            internal sealed class DiffLemonChiffonFormat : ClassificationFormatDefinition{

                public DiffLemonChiffonFormat() { 
					this.ForegroundColor = Colors.LemonChiffon; 
				}
            }
                    
            /* -- LightBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.lightblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightblue")]
            [Name("text.lightblue")]
            internal sealed class DiffLightBlueFormat : ClassificationFormatDefinition{

                public DiffLightBlueFormat() { 
					this.ForegroundColor = Colors.LightBlue; 
				}
            }
                    
            /* -- LightCoral --------------------------------------------------------  */
            [Export][Name("coloredtext.lightcoral")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightCoralDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightcoral")]
            [Name("text.lightcoral")]
            internal sealed class DiffLightCoralFormat : ClassificationFormatDefinition{

                public DiffLightCoralFormat() { 
					this.ForegroundColor = Colors.LightCoral; 
				}
            }
                    
            /* -- LightCyan --------------------------------------------------------  */
            [Export][Name("coloredtext.lightcyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightcyan")]
            [Name("text.lightcyan")]
            internal sealed class DiffLightCyanFormat : ClassificationFormatDefinition{

                public DiffLightCyanFormat() { 
					this.ForegroundColor = Colors.LightCyan; 
				}
            }
                    
            /* -- LightGoldenrodYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.lightgoldenrodyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightGoldenrodYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightgoldenrodyellow")]
            [Name("text.lightgoldenrodyellow")]
            internal sealed class DiffLightGoldenrodYellowFormat : ClassificationFormatDefinition{

                public DiffLightGoldenrodYellowFormat() { 
					this.ForegroundColor = Colors.LightGoldenrodYellow; 
				}
            }
                    
            /* -- LightGray --------------------------------------------------------  */
            [Export][Name("coloredtext.lightgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightgray")]
            [Name("text.lightgray")]
            internal sealed class DiffLightGrayFormat : ClassificationFormatDefinition{

                public DiffLightGrayFormat() { 
					this.ForegroundColor = Colors.LightGray; 
				}
            }
                    
            /* -- LightGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.lightgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightgreen")]
            [Name("text.lightgreen")]
            internal sealed class DiffLightGreenFormat : ClassificationFormatDefinition{

                public DiffLightGreenFormat() { 
					this.ForegroundColor = Colors.LightGreen; 
				}
            }
                    
            /* -- LightPink --------------------------------------------------------  */
            [Export][Name("coloredtext.lightpink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightpink")]
            [Name("text.lightpink")]
            internal sealed class DiffLightPinkFormat : ClassificationFormatDefinition{

                public DiffLightPinkFormat() { 
					this.ForegroundColor = Colors.LightPink; 
				}
            }
                    
            /* -- LightSalmon --------------------------------------------------------  */
            [Export][Name("coloredtext.lightsalmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightsalmon")]
            [Name("text.lightsalmon")]
            internal sealed class DiffLightSalmonFormat : ClassificationFormatDefinition{

                public DiffLightSalmonFormat() { 
					this.ForegroundColor = Colors.LightSalmon; 
				}
            }
                    
            /* -- LightSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.lightseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightseagreen")]
            [Name("text.lightseagreen")]
            internal sealed class DiffLightSeaGreenFormat : ClassificationFormatDefinition{

                public DiffLightSeaGreenFormat() { 
					this.ForegroundColor = Colors.LightSeaGreen; 
				}
            }
                    
            /* -- LightSkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.lightskyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightskyblue")]
            [Name("text.lightskyblue")]
            internal sealed class DiffLightSkyBlueFormat : ClassificationFormatDefinition{

                public DiffLightSkyBlueFormat() { 
					this.ForegroundColor = Colors.LightSkyBlue; 
				}
            }
                    
            /* -- LightSlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.lightslategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightslategray")]
            [Name("text.lightslategray")]
            internal sealed class DiffLightSlateGrayFormat : ClassificationFormatDefinition{

                public DiffLightSlateGrayFormat() { 
					this.ForegroundColor = Colors.LightSlateGray; 
				}
            }
                    
            /* -- LightSteelBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.lightsteelblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightSteelBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightsteelblue")]
            [Name("text.lightsteelblue")]
            internal sealed class DiffLightSteelBlueFormat : ClassificationFormatDefinition{

                public DiffLightSteelBlueFormat() { 
					this.ForegroundColor = Colors.LightSteelBlue; 
				}
            }
                    
            /* -- LightYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.lightyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLightYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lightyellow")]
            [Name("text.lightyellow")]
            internal sealed class DiffLightYellowFormat : ClassificationFormatDefinition{

                public DiffLightYellowFormat() { 
					this.ForegroundColor = Colors.LightYellow; 
				}
            }
                    
            /* -- Lime --------------------------------------------------------  */
            [Export][Name("coloredtext.lime")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLimeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.lime")]
            [Name("text.lime")]
            internal sealed class DiffLimeFormat : ClassificationFormatDefinition{

                public DiffLimeFormat() { 
					this.ForegroundColor = Colors.Lime; 
				}
            }
                    
            /* -- LimeGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.limegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLimeGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.limegreen")]
            [Name("text.limegreen")]
            internal sealed class DiffLimeGreenFormat : ClassificationFormatDefinition{

                public DiffLimeGreenFormat() { 
					this.ForegroundColor = Colors.LimeGreen; 
				}
            }
                    
            /* -- Linen --------------------------------------------------------  */
            [Export][Name("coloredtext.linen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffLinenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.linen")]
            [Name("text.linen")]
            internal sealed class DiffLinenFormat : ClassificationFormatDefinition{

                public DiffLinenFormat() { 
					this.ForegroundColor = Colors.Linen; 
				}
            }
                    
            /* -- Magenta --------------------------------------------------------  */
            [Export][Name("coloredtext.magenta")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMagentaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.magenta")]
            [Name("text.magenta")]
            internal sealed class DiffMagentaFormat : ClassificationFormatDefinition{

                public DiffMagentaFormat() { 
					this.ForegroundColor = Colors.Magenta; 
				}
            }
                    
            /* -- Maroon --------------------------------------------------------  */
            [Export][Name("coloredtext.maroon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMaroonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.maroon")]
            [Name("text.maroon")]
            internal sealed class DiffMaroonFormat : ClassificationFormatDefinition{

                public DiffMaroonFormat() { 
					this.ForegroundColor = Colors.Maroon; 
				}
            }
                    
            /* -- MediumAquamarine --------------------------------------------------------  */
            [Export][Name("coloredtext.mediumaquamarine")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMediumAquamarineDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mediumaquamarine")]
            [Name("text.mediumaquamarine")]
            internal sealed class DiffMediumAquamarineFormat : ClassificationFormatDefinition{

                public DiffMediumAquamarineFormat() { 
					this.ForegroundColor = Colors.MediumAquamarine; 
				}
            }
                    
            /* -- MediumBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.mediumblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMediumBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mediumblue")]
            [Name("text.mediumblue")]
            internal sealed class DiffMediumBlueFormat : ClassificationFormatDefinition{

                public DiffMediumBlueFormat() { 
					this.ForegroundColor = Colors.MediumBlue; 
				}
            }
                    
            /* -- MediumOrchid --------------------------------------------------------  */
            [Export][Name("coloredtext.mediumorchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMediumOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mediumorchid")]
            [Name("text.mediumorchid")]
            internal sealed class DiffMediumOrchidFormat : ClassificationFormatDefinition{

                public DiffMediumOrchidFormat() { 
					this.ForegroundColor = Colors.MediumOrchid; 
				}
            }
                    
            /* -- MediumPurple --------------------------------------------------------  */
            [Export][Name("coloredtext.mediumpurple")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMediumPurpleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mediumpurple")]
            [Name("text.mediumpurple")]
            internal sealed class DiffMediumPurpleFormat : ClassificationFormatDefinition{

                public DiffMediumPurpleFormat() { 
					this.ForegroundColor = Colors.MediumPurple; 
				}
            }
                    
            /* -- MediumSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.mediumseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMediumSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mediumseagreen")]
            [Name("text.mediumseagreen")]
            internal sealed class DiffMediumSeaGreenFormat : ClassificationFormatDefinition{

                public DiffMediumSeaGreenFormat() { 
					this.ForegroundColor = Colors.MediumSeaGreen; 
				}
            }
                    
            /* -- MediumSlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.mediumslateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMediumSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mediumslateblue")]
            [Name("text.mediumslateblue")]
            internal sealed class DiffMediumSlateBlueFormat : ClassificationFormatDefinition{

                public DiffMediumSlateBlueFormat() { 
					this.ForegroundColor = Colors.MediumSlateBlue; 
				}
            }
                    
            /* -- MediumSpringGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.mediumspringgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMediumSpringGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mediumspringgreen")]
            [Name("text.mediumspringgreen")]
            internal sealed class DiffMediumSpringGreenFormat : ClassificationFormatDefinition{

                public DiffMediumSpringGreenFormat() { 
					this.ForegroundColor = Colors.MediumSpringGreen; 
				}
            }
                    
            /* -- MediumTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.mediumturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMediumTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mediumturquoise")]
            [Name("text.mediumturquoise")]
            internal sealed class DiffMediumTurquoiseFormat : ClassificationFormatDefinition{

                public DiffMediumTurquoiseFormat() { 
					this.ForegroundColor = Colors.MediumTurquoise; 
				}
            }
                    
            /* -- MediumVioletRed --------------------------------------------------------  */
            [Export][Name("coloredtext.mediumvioletred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMediumVioletRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mediumvioletred")]
            [Name("text.mediumvioletred")]
            internal sealed class DiffMediumVioletRedFormat : ClassificationFormatDefinition{

                public DiffMediumVioletRedFormat() { 
					this.ForegroundColor = Colors.MediumVioletRed; 
				}
            }
                    
            /* -- MidnightBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.midnightblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMidnightBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.midnightblue")]
            [Name("text.midnightblue")]
            internal sealed class DiffMidnightBlueFormat : ClassificationFormatDefinition{

                public DiffMidnightBlueFormat() { 
					this.ForegroundColor = Colors.MidnightBlue; 
				}
            }
                    
            /* -- MintCream --------------------------------------------------------  */
            [Export][Name("coloredtext.mintcream")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMintCreamDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mintcream")]
            [Name("text.mintcream")]
            internal sealed class DiffMintCreamFormat : ClassificationFormatDefinition{

                public DiffMintCreamFormat() { 
					this.ForegroundColor = Colors.MintCream; 
				}
            }
                    
            /* -- MistyRose --------------------------------------------------------  */
            [Export][Name("coloredtext.mistyrose")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMistyRoseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.mistyrose")]
            [Name("text.mistyrose")]
            internal sealed class DiffMistyRoseFormat : ClassificationFormatDefinition{

                public DiffMistyRoseFormat() { 
					this.ForegroundColor = Colors.MistyRose; 
				}
            }
                    
            /* -- Moccasin --------------------------------------------------------  */
            [Export][Name("coloredtext.moccasin")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffMoccasinDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.moccasin")]
            [Name("text.moccasin")]
            internal sealed class DiffMoccasinFormat : ClassificationFormatDefinition{

                public DiffMoccasinFormat() { 
					this.ForegroundColor = Colors.Moccasin; 
				}
            }
                    
            /* -- NavajoWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.navajowhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffNavajoWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.navajowhite")]
            [Name("text.navajowhite")]
            internal sealed class DiffNavajoWhiteFormat : ClassificationFormatDefinition{

                public DiffNavajoWhiteFormat() { 
					this.ForegroundColor = Colors.NavajoWhite; 
				}
            }
                    
            /* -- Navy --------------------------------------------------------  */
            [Export][Name("coloredtext.navy")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffNavyDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.navy")]
            [Name("text.navy")]
            internal sealed class DiffNavyFormat : ClassificationFormatDefinition{

                public DiffNavyFormat() { 
					this.ForegroundColor = Colors.Navy; 
				}
            }
                    
            /* -- OldLace --------------------------------------------------------  */
            [Export][Name("coloredtext.oldlace")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffOldLaceDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.oldlace")]
            [Name("text.oldlace")]
            internal sealed class DiffOldLaceFormat : ClassificationFormatDefinition{

                public DiffOldLaceFormat() { 
					this.ForegroundColor = Colors.OldLace; 
				}
            }
                    
            /* -- Olive --------------------------------------------------------  */
            [Export][Name("coloredtext.olive")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffOliveDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.olive")]
            [Name("text.olive")]
            internal sealed class DiffOliveFormat : ClassificationFormatDefinition{

                public DiffOliveFormat() { 
					this.ForegroundColor = Colors.Olive; 
				}
            }
                    
            /* -- OliveDrab --------------------------------------------------------  */
            [Export][Name("coloredtext.olivedrab")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffOliveDrabDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.olivedrab")]
            [Name("text.olivedrab")]
            internal sealed class DiffOliveDrabFormat : ClassificationFormatDefinition{

                public DiffOliveDrabFormat() { 
					this.ForegroundColor = Colors.OliveDrab; 
				}
            }
                    
            /* -- Orange --------------------------------------------------------  */
            [Export][Name("coloredtext.orange")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffOrangeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.orange")]
            [Name("text.orange")]
            internal sealed class DiffOrangeFormat : ClassificationFormatDefinition{

                public DiffOrangeFormat() { 
					this.ForegroundColor = Colors.Orange; 
				}
            }
                    
            /* -- OrangeRed --------------------------------------------------------  */
            [Export][Name("coloredtext.orangered")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffOrangeRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.orangered")]
            [Name("text.orangered")]
            internal sealed class DiffOrangeRedFormat : ClassificationFormatDefinition{

                public DiffOrangeRedFormat() { 
					this.ForegroundColor = Colors.OrangeRed; 
				}
            }
                    
            /* -- Orchid --------------------------------------------------------  */
            [Export][Name("coloredtext.orchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.orchid")]
            [Name("text.orchid")]
            internal sealed class DiffOrchidFormat : ClassificationFormatDefinition{

                public DiffOrchidFormat() { 
					this.ForegroundColor = Colors.Orchid; 
				}
            }
                    
            /* -- PaleGoldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.palegoldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPaleGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.palegoldenrod")]
            [Name("text.palegoldenrod")]
            internal sealed class DiffPaleGoldenrodFormat : ClassificationFormatDefinition{

                public DiffPaleGoldenrodFormat() { 
					this.ForegroundColor = Colors.PaleGoldenrod; 
				}
            }
                    
            /* -- PaleGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.palegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPaleGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.palegreen")]
            [Name("text.palegreen")]
            internal sealed class DiffPaleGreenFormat : ClassificationFormatDefinition{

                public DiffPaleGreenFormat() { 
					this.ForegroundColor = Colors.PaleGreen; 
				}
            }
                    
            /* -- PaleTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.paleturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPaleTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.paleturquoise")]
            [Name("text.paleturquoise")]
            internal sealed class DiffPaleTurquoiseFormat : ClassificationFormatDefinition{

                public DiffPaleTurquoiseFormat() { 
					this.ForegroundColor = Colors.PaleTurquoise; 
				}
            }
                    
            /* -- PaleVioletRed --------------------------------------------------------  */
            [Export][Name("coloredtext.palevioletred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPaleVioletRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.palevioletred")]
            [Name("text.palevioletred")]
            internal sealed class DiffPaleVioletRedFormat : ClassificationFormatDefinition{

                public DiffPaleVioletRedFormat() { 
					this.ForegroundColor = Colors.PaleVioletRed; 
				}
            }
                    
            /* -- PapayaWhip --------------------------------------------------------  */
            [Export][Name("coloredtext.papayawhip")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPapayaWhipDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.papayawhip")]
            [Name("text.papayawhip")]
            internal sealed class DiffPapayaWhipFormat : ClassificationFormatDefinition{

                public DiffPapayaWhipFormat() { 
					this.ForegroundColor = Colors.PapayaWhip; 
				}
            }
                    
            /* -- PeachPuff --------------------------------------------------------  */
            [Export][Name("coloredtext.peachpuff")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPeachPuffDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.peachpuff")]
            [Name("text.peachpuff")]
            internal sealed class DiffPeachPuffFormat : ClassificationFormatDefinition{

                public DiffPeachPuffFormat() { 
					this.ForegroundColor = Colors.PeachPuff; 
				}
            }
                    
            /* -- Peru --------------------------------------------------------  */
            [Export][Name("coloredtext.peru")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPeruDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.peru")]
            [Name("text.peru")]
            internal sealed class DiffPeruFormat : ClassificationFormatDefinition{

                public DiffPeruFormat() { 
					this.ForegroundColor = Colors.Peru; 
				}
            }
                    
            /* -- Pink --------------------------------------------------------  */
            [Export][Name("coloredtext.pink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.pink")]
            [Name("text.pink")]
            internal sealed class DiffPinkFormat : ClassificationFormatDefinition{

                public DiffPinkFormat() { 
					this.ForegroundColor = Colors.Pink; 
				}
            }
                    
            /* -- Plum --------------------------------------------------------  */
            [Export][Name("coloredtext.plum")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPlumDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.plum")]
            [Name("text.plum")]
            internal sealed class DiffPlumFormat : ClassificationFormatDefinition{

                public DiffPlumFormat() { 
					this.ForegroundColor = Colors.Plum; 
				}
            }
                    
            /* -- PowderBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.powderblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPowderBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.powderblue")]
            [Name("text.powderblue")]
            internal sealed class DiffPowderBlueFormat : ClassificationFormatDefinition{

                public DiffPowderBlueFormat() { 
					this.ForegroundColor = Colors.PowderBlue; 
				}
            }
                    
            /* -- Purple --------------------------------------------------------  */
            [Export][Name("coloredtext.purple")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffPurpleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.purple")]
            [Name("text.purple")]
            internal sealed class DiffPurpleFormat : ClassificationFormatDefinition{

                public DiffPurpleFormat() { 
					this.ForegroundColor = Colors.Purple; 
				}
            }
                    
            /* -- Red --------------------------------------------------------  */
            [Export][Name("coloredtext.red")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.red")]
            [Name("text.red")]
            internal sealed class DiffRedFormat : ClassificationFormatDefinition{

                public DiffRedFormat() { 
					this.ForegroundColor = Colors.Red; 
				}
            }
                    
            /* -- RosyBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.rosybrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffRosyBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.rosybrown")]
            [Name("text.rosybrown")]
            internal sealed class DiffRosyBrownFormat : ClassificationFormatDefinition{

                public DiffRosyBrownFormat() { 
					this.ForegroundColor = Colors.RosyBrown; 
				}
            }
                    
            /* -- RoyalBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.royalblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffRoyalBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.royalblue")]
            [Name("text.royalblue")]
            internal sealed class DiffRoyalBlueFormat : ClassificationFormatDefinition{

                public DiffRoyalBlueFormat() { 
					this.ForegroundColor = Colors.RoyalBlue; 
				}
            }
                    
            /* -- SaddleBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.saddlebrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSaddleBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.saddlebrown")]
            [Name("text.saddlebrown")]
            internal sealed class DiffSaddleBrownFormat : ClassificationFormatDefinition{

                public DiffSaddleBrownFormat() { 
					this.ForegroundColor = Colors.SaddleBrown; 
				}
            }
                    
            /* -- Salmon --------------------------------------------------------  */
            [Export][Name("coloredtext.salmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.salmon")]
            [Name("text.salmon")]
            internal sealed class DiffSalmonFormat : ClassificationFormatDefinition{

                public DiffSalmonFormat() { 
					this.ForegroundColor = Colors.Salmon; 
				}
            }
                    
            /* -- SandyBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.sandybrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSandyBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.sandybrown")]
            [Name("text.sandybrown")]
            internal sealed class DiffSandyBrownFormat : ClassificationFormatDefinition{

                public DiffSandyBrownFormat() { 
					this.ForegroundColor = Colors.SandyBrown; 
				}
            }
                    
            /* -- SeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.seagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.seagreen")]
            [Name("text.seagreen")]
            internal sealed class DiffSeaGreenFormat : ClassificationFormatDefinition{

                public DiffSeaGreenFormat() { 
					this.ForegroundColor = Colors.SeaGreen; 
				}
            }
                    
            /* -- SeaShell --------------------------------------------------------  */
            [Export][Name("coloredtext.seashell")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSeaShellDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.seashell")]
            [Name("text.seashell")]
            internal sealed class DiffSeaShellFormat : ClassificationFormatDefinition{

                public DiffSeaShellFormat() { 
					this.ForegroundColor = Colors.SeaShell; 
				}
            }
                    
            /* -- Sienna --------------------------------------------------------  */
            [Export][Name("coloredtext.sienna")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSiennaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.sienna")]
            [Name("text.sienna")]
            internal sealed class DiffSiennaFormat : ClassificationFormatDefinition{

                public DiffSiennaFormat() { 
					this.ForegroundColor = Colors.Sienna; 
				}
            }
                    
            /* -- Silver --------------------------------------------------------  */
            [Export][Name("coloredtext.silver")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSilverDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.silver")]
            [Name("text.silver")]
            internal sealed class DiffSilverFormat : ClassificationFormatDefinition{

                public DiffSilverFormat() { 
					this.ForegroundColor = Colors.Silver; 
				}
            }
                    
            /* -- SkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.skyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.skyblue")]
            [Name("text.skyblue")]
            internal sealed class DiffSkyBlueFormat : ClassificationFormatDefinition{

                public DiffSkyBlueFormat() { 
					this.ForegroundColor = Colors.SkyBlue; 
				}
            }
                    
            /* -- SlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.slateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.slateblue")]
            [Name("text.slateblue")]
            internal sealed class DiffSlateBlueFormat : ClassificationFormatDefinition{

                public DiffSlateBlueFormat() { 
					this.ForegroundColor = Colors.SlateBlue; 
				}
            }
                    
            /* -- SlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.slategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.slategray")]
            [Name("text.slategray")]
            internal sealed class DiffSlateGrayFormat : ClassificationFormatDefinition{

                public DiffSlateGrayFormat() { 
					this.ForegroundColor = Colors.SlateGray; 
				}
            }
                    
            /* -- Snow --------------------------------------------------------  */
            [Export][Name("coloredtext.snow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSnowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.snow")]
            [Name("text.snow")]
            internal sealed class DiffSnowFormat : ClassificationFormatDefinition{

                public DiffSnowFormat() { 
					this.ForegroundColor = Colors.Snow; 
				}
            }
                    
            /* -- SpringGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.springgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSpringGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.springgreen")]
            [Name("text.springgreen")]
            internal sealed class DiffSpringGreenFormat : ClassificationFormatDefinition{

                public DiffSpringGreenFormat() { 
					this.ForegroundColor = Colors.SpringGreen; 
				}
            }
                    
            /* -- SteelBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.steelblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffSteelBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.steelblue")]
            [Name("text.steelblue")]
            internal sealed class DiffSteelBlueFormat : ClassificationFormatDefinition{

                public DiffSteelBlueFormat() { 
					this.ForegroundColor = Colors.SteelBlue; 
				}
            }
                    
            /* -- Tan --------------------------------------------------------  */
            [Export][Name("coloredtext.tan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffTanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.tan")]
            [Name("text.tan")]
            internal sealed class DiffTanFormat : ClassificationFormatDefinition{

                public DiffTanFormat() { 
					this.ForegroundColor = Colors.Tan; 
				}
            }
                    
            /* -- Teal --------------------------------------------------------  */
            [Export][Name("coloredtext.teal")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffTealDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.teal")]
            [Name("text.teal")]
            internal sealed class DiffTealFormat : ClassificationFormatDefinition{

                public DiffTealFormat() { 
					this.ForegroundColor = Colors.Teal; 
				}
            }
                    
            /* -- Thistle --------------------------------------------------------  */
            [Export][Name("coloredtext.thistle")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffThistleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.thistle")]
            [Name("text.thistle")]
            internal sealed class DiffThistleFormat : ClassificationFormatDefinition{

                public DiffThistleFormat() { 
					this.ForegroundColor = Colors.Thistle; 
				}
            }
                    
            /* -- Tomato --------------------------------------------------------  */
            [Export][Name("coloredtext.tomato")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffTomatoDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.tomato")]
            [Name("text.tomato")]
            internal sealed class DiffTomatoFormat : ClassificationFormatDefinition{

                public DiffTomatoFormat() { 
					this.ForegroundColor = Colors.Tomato; 
				}
            }
                    
            /* -- Transparent --------------------------------------------------------  */
            [Export][Name("coloredtext.transparent")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffTransparentDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.transparent")]
            [Name("text.transparent")]
            internal sealed class DiffTransparentFormat : ClassificationFormatDefinition{

                public DiffTransparentFormat() { 
					this.ForegroundColor = Colors.Transparent; 
				}
            }
                    
            /* -- Turquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.turquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.turquoise")]
            [Name("text.turquoise")]
            internal sealed class DiffTurquoiseFormat : ClassificationFormatDefinition{

                public DiffTurquoiseFormat() { 
					this.ForegroundColor = Colors.Turquoise; 
				}
            }
                    
            /* -- Violet --------------------------------------------------------  */
            [Export][Name("coloredtext.violet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.violet")]
            [Name("text.violet")]
            internal sealed class DiffVioletFormat : ClassificationFormatDefinition{

                public DiffVioletFormat() { 
					this.ForegroundColor = Colors.Violet; 
				}
            }
                    
            /* -- Wheat --------------------------------------------------------  */
            [Export][Name("coloredtext.wheat")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffWheatDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.wheat")]
            [Name("text.wheat")]
            internal sealed class DiffWheatFormat : ClassificationFormatDefinition{

                public DiffWheatFormat() { 
					this.ForegroundColor = Colors.Wheat; 
				}
            }
                    
            /* -- White --------------------------------------------------------  */
            [Export][Name("coloredtext.white")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.white")]
            [Name("text.white")]
            internal sealed class DiffWhiteFormat : ClassificationFormatDefinition{

                public DiffWhiteFormat() { 
					this.ForegroundColor = Colors.White; 
				}
            }
                    
            /* -- WhiteSmoke --------------------------------------------------------  */
            [Export][Name("coloredtext.whitesmoke")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffWhiteSmokeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.whitesmoke")]
            [Name("text.whitesmoke")]
            internal sealed class DiffWhiteSmokeFormat : ClassificationFormatDefinition{

                public DiffWhiteSmokeFormat() { 
					this.ForegroundColor = Colors.WhiteSmoke; 
				}
            }
                    
            /* -- Yellow --------------------------------------------------------  */
            [Export][Name("coloredtext.yellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.yellow")]
            [Name("text.yellow")]
            internal sealed class DiffYellowFormat : ClassificationFormatDefinition{

                public DiffYellowFormat() { 
					this.ForegroundColor = Colors.Yellow; 
				}
            }
                    
            /* -- YellowGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.yellowgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffYellowGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.yellowgreen")]
            [Name("text.yellowgreen")]
            internal sealed class DiffYellowGreenFormat : ClassificationFormatDefinition{

                public DiffYellowGreenFormat() { 
					this.ForegroundColor = Colors.YellowGreen; 
				}
            }
        
            /* -- RedAttention --------------------------------------------------------  */
            [Export][Name("coloredtext.redattention")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffRedAttentionDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.redattention")]
            [Name("text.redattention")]
            internal sealed class DiffRedAttentionFormat : ClassificationFormatDefinition{

                public DiffRedAttentionFormat() { 
                    this.ForegroundColor = Colors.Red; 
                    this.BackgroundColor = Colors.Yellow;
                }
            }
            


    }
}