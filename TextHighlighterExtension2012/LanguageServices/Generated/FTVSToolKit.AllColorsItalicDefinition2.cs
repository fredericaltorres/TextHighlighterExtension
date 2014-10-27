
using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
   
namespace FTVSToolKit { //AA 
 
    internal static class AllColorsItalicDefinition { // DiffClassificationDefinitions
	
                    
            /* -- AliceBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.aliceblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicAliceBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.aliceblue")]
            [Name("text.italic.aliceblue")]
            internal sealed class DiffitalicAliceBlueFormat : ClassificationFormatDefinition{

                public DiffitalicAliceBlueFormat() { 
					this.ForegroundColor = Colors.AliceBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- AntiqueWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.antiquewhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicAntiqueWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.antiquewhite")]
            [Name("text.italic.antiquewhite")]
            internal sealed class DiffitalicAntiqueWhiteFormat : ClassificationFormatDefinition{

                public DiffitalicAntiqueWhiteFormat() { 
					this.ForegroundColor = Colors.AntiqueWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Aqua --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.aqua")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicAquaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.aqua")]
            [Name("text.italic.aqua")]
            internal sealed class DiffitalicAquaFormat : ClassificationFormatDefinition{

                public DiffitalicAquaFormat() { 
					this.ForegroundColor = Colors.Aqua; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Aquamarine --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.aquamarine")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicAquamarineDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.aquamarine")]
            [Name("text.italic.aquamarine")]
            internal sealed class DiffitalicAquamarineFormat : ClassificationFormatDefinition{

                public DiffitalicAquamarineFormat() { 
					this.ForegroundColor = Colors.Aquamarine; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Azure --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.azure")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicAzureDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.azure")]
            [Name("text.italic.azure")]
            internal sealed class DiffitalicAzureFormat : ClassificationFormatDefinition{

                public DiffitalicAzureFormat() { 
					this.ForegroundColor = Colors.Azure; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Beige --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.beige")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicBeigeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.beige")]
            [Name("text.italic.beige")]
            internal sealed class DiffitalicBeigeFormat : ClassificationFormatDefinition{

                public DiffitalicBeigeFormat() { 
					this.ForegroundColor = Colors.Beige; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Bisque --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.bisque")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicBisqueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.bisque")]
            [Name("text.italic.bisque")]
            internal sealed class DiffitalicBisqueFormat : ClassificationFormatDefinition{

                public DiffitalicBisqueFormat() { 
					this.ForegroundColor = Colors.Bisque; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Black --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.black")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicBlackDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.black")]
            [Name("text.italic.black")]
            internal sealed class DiffitalicBlackFormat : ClassificationFormatDefinition{

                public DiffitalicBlackFormat() { 
					this.ForegroundColor = Colors.Black; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- BlanchedAlmond --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.blanchedalmond")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicBlanchedAlmondDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.blanchedalmond")]
            [Name("text.italic.blanchedalmond")]
            internal sealed class DiffitalicBlanchedAlmondFormat : ClassificationFormatDefinition{

                public DiffitalicBlanchedAlmondFormat() { 
					this.ForegroundColor = Colors.BlanchedAlmond; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Blue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.blue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.blue")]
            [Name("text.italic.blue")]
            internal sealed class DiffitalicBlueFormat : ClassificationFormatDefinition{

                public DiffitalicBlueFormat() { 
					this.ForegroundColor = Colors.Blue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- BlueViolet --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.blueviolet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicBlueVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.blueviolet")]
            [Name("text.italic.blueviolet")]
            internal sealed class DiffitalicBlueVioletFormat : ClassificationFormatDefinition{

                public DiffitalicBlueVioletFormat() { 
					this.ForegroundColor = Colors.BlueViolet; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Brown --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.brown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.brown")]
            [Name("text.italic.brown")]
            internal sealed class DiffitalicBrownFormat : ClassificationFormatDefinition{

                public DiffitalicBrownFormat() { 
					this.ForegroundColor = Colors.Brown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- BurlyWood --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.burlywood")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicBurlyWoodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.burlywood")]
            [Name("text.italic.burlywood")]
            internal sealed class DiffitalicBurlyWoodFormat : ClassificationFormatDefinition{

                public DiffitalicBurlyWoodFormat() { 
					this.ForegroundColor = Colors.BurlyWood; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- CadetBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.cadetblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicCadetBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.cadetblue")]
            [Name("text.italic.cadetblue")]
            internal sealed class DiffitalicCadetBlueFormat : ClassificationFormatDefinition{

                public DiffitalicCadetBlueFormat() { 
					this.ForegroundColor = Colors.CadetBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Chartreuse --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.chartreuse")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicChartreuseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.chartreuse")]
            [Name("text.italic.chartreuse")]
            internal sealed class DiffitalicChartreuseFormat : ClassificationFormatDefinition{

                public DiffitalicChartreuseFormat() { 
					this.ForegroundColor = Colors.Chartreuse; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Chocolate --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.chocolate")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicChocolateDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.chocolate")]
            [Name("text.italic.chocolate")]
            internal sealed class DiffitalicChocolateFormat : ClassificationFormatDefinition{

                public DiffitalicChocolateFormat() { 
					this.ForegroundColor = Colors.Chocolate; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Coral --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.coral")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicCoralDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.coral")]
            [Name("text.italic.coral")]
            internal sealed class DiffitalicCoralFormat : ClassificationFormatDefinition{

                public DiffitalicCoralFormat() { 
					this.ForegroundColor = Colors.Coral; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- CornflowerBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.cornflowerblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicCornflowerBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.cornflowerblue")]
            [Name("text.italic.cornflowerblue")]
            internal sealed class DiffitalicCornflowerBlueFormat : ClassificationFormatDefinition{

                public DiffitalicCornflowerBlueFormat() { 
					this.ForegroundColor = Colors.CornflowerBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Cornsilk --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.cornsilk")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicCornsilkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.cornsilk")]
            [Name("text.italic.cornsilk")]
            internal sealed class DiffitalicCornsilkFormat : ClassificationFormatDefinition{

                public DiffitalicCornsilkFormat() { 
					this.ForegroundColor = Colors.Cornsilk; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Crimson --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.crimson")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicCrimsonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.crimson")]
            [Name("text.italic.crimson")]
            internal sealed class DiffitalicCrimsonFormat : ClassificationFormatDefinition{

                public DiffitalicCrimsonFormat() { 
					this.ForegroundColor = Colors.Crimson; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Cyan --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.cyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.cyan")]
            [Name("text.italic.cyan")]
            internal sealed class DiffitalicCyanFormat : ClassificationFormatDefinition{

                public DiffitalicCyanFormat() { 
					this.ForegroundColor = Colors.Cyan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkblue")]
            [Name("text.italic.darkblue")]
            internal sealed class DiffitalicDarkBlueFormat : ClassificationFormatDefinition{

                public DiffitalicDarkBlueFormat() { 
					this.ForegroundColor = Colors.DarkBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkCyan --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkcyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkcyan")]
            [Name("text.italic.darkcyan")]
            internal sealed class DiffitalicDarkCyanFormat : ClassificationFormatDefinition{

                public DiffitalicDarkCyanFormat() { 
					this.ForegroundColor = Colors.DarkCyan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkGoldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkgoldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkgoldenrod")]
            [Name("text.italic.darkgoldenrod")]
            internal sealed class DiffitalicDarkGoldenrodFormat : ClassificationFormatDefinition{

                public DiffitalicDarkGoldenrodFormat() { 
					this.ForegroundColor = Colors.DarkGoldenrod; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkGray --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkgray")]
            [Name("text.italic.darkgray")]
            internal sealed class DiffitalicDarkGrayFormat : ClassificationFormatDefinition{

                public DiffitalicDarkGrayFormat() { 
					this.ForegroundColor = Colors.DarkGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkgreen")]
            [Name("text.italic.darkgreen")]
            internal sealed class DiffitalicDarkGreenFormat : ClassificationFormatDefinition{

                public DiffitalicDarkGreenFormat() { 
					this.ForegroundColor = Colors.DarkGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkKhaki --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkkhaki")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkKhakiDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkkhaki")]
            [Name("text.italic.darkkhaki")]
            internal sealed class DiffitalicDarkKhakiFormat : ClassificationFormatDefinition{

                public DiffitalicDarkKhakiFormat() { 
					this.ForegroundColor = Colors.DarkKhaki; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkMagenta --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkmagenta")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkMagentaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkmagenta")]
            [Name("text.italic.darkmagenta")]
            internal sealed class DiffitalicDarkMagentaFormat : ClassificationFormatDefinition{

                public DiffitalicDarkMagentaFormat() { 
					this.ForegroundColor = Colors.DarkMagenta; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkOliveGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkolivegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkOliveGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkolivegreen")]
            [Name("text.italic.darkolivegreen")]
            internal sealed class DiffitalicDarkOliveGreenFormat : ClassificationFormatDefinition{

                public DiffitalicDarkOliveGreenFormat() { 
					this.ForegroundColor = Colors.DarkOliveGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkOrange --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkorange")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkOrangeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkorange")]
            [Name("text.italic.darkorange")]
            internal sealed class DiffitalicDarkOrangeFormat : ClassificationFormatDefinition{

                public DiffitalicDarkOrangeFormat() { 
					this.ForegroundColor = Colors.DarkOrange; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkOrchid --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkorchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkorchid")]
            [Name("text.italic.darkorchid")]
            internal sealed class DiffitalicDarkOrchidFormat : ClassificationFormatDefinition{

                public DiffitalicDarkOrchidFormat() { 
					this.ForegroundColor = Colors.DarkOrchid; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkRed --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkred")]
            [Name("text.italic.darkred")]
            internal sealed class DiffitalicDarkRedFormat : ClassificationFormatDefinition{

                public DiffitalicDarkRedFormat() { 
					this.ForegroundColor = Colors.DarkRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkSalmon --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darksalmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darksalmon")]
            [Name("text.italic.darksalmon")]
            internal sealed class DiffitalicDarkSalmonFormat : ClassificationFormatDefinition{

                public DiffitalicDarkSalmonFormat() { 
					this.ForegroundColor = Colors.DarkSalmon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkseagreen")]
            [Name("text.italic.darkseagreen")]
            internal sealed class DiffitalicDarkSeaGreenFormat : ClassificationFormatDefinition{

                public DiffitalicDarkSeaGreenFormat() { 
					this.ForegroundColor = Colors.DarkSeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkSlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkslateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkslateblue")]
            [Name("text.italic.darkslateblue")]
            internal sealed class DiffitalicDarkSlateBlueFormat : ClassificationFormatDefinition{

                public DiffitalicDarkSlateBlueFormat() { 
					this.ForegroundColor = Colors.DarkSlateBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkSlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkslategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkslategray")]
            [Name("text.italic.darkslategray")]
            internal sealed class DiffitalicDarkSlateGrayFormat : ClassificationFormatDefinition{

                public DiffitalicDarkSlateGrayFormat() { 
					this.ForegroundColor = Colors.DarkSlateGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkturquoise")]
            [Name("text.italic.darkturquoise")]
            internal sealed class DiffitalicDarkTurquoiseFormat : ClassificationFormatDefinition{

                public DiffitalicDarkTurquoiseFormat() { 
					this.ForegroundColor = Colors.DarkTurquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkViolet --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.darkviolet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDarkVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.darkviolet")]
            [Name("text.italic.darkviolet")]
            internal sealed class DiffitalicDarkVioletFormat : ClassificationFormatDefinition{

                public DiffitalicDarkVioletFormat() { 
					this.ForegroundColor = Colors.DarkViolet; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DeepPink --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.deeppink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDeepPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.deeppink")]
            [Name("text.italic.deeppink")]
            internal sealed class DiffitalicDeepPinkFormat : ClassificationFormatDefinition{

                public DiffitalicDeepPinkFormat() { 
					this.ForegroundColor = Colors.DeepPink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DeepSkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.deepskyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDeepSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.deepskyblue")]
            [Name("text.italic.deepskyblue")]
            internal sealed class DiffitalicDeepSkyBlueFormat : ClassificationFormatDefinition{

                public DiffitalicDeepSkyBlueFormat() { 
					this.ForegroundColor = Colors.DeepSkyBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DimGray --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.dimgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDimGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.dimgray")]
            [Name("text.italic.dimgray")]
            internal sealed class DiffitalicDimGrayFormat : ClassificationFormatDefinition{

                public DiffitalicDimGrayFormat() { 
					this.ForegroundColor = Colors.DimGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DodgerBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.dodgerblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicDodgerBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.dodgerblue")]
            [Name("text.italic.dodgerblue")]
            internal sealed class DiffitalicDodgerBlueFormat : ClassificationFormatDefinition{

                public DiffitalicDodgerBlueFormat() { 
					this.ForegroundColor = Colors.DodgerBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Firebrick --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.firebrick")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicFirebrickDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.firebrick")]
            [Name("text.italic.firebrick")]
            internal sealed class DiffitalicFirebrickFormat : ClassificationFormatDefinition{

                public DiffitalicFirebrickFormat() { 
					this.ForegroundColor = Colors.Firebrick; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- FloralWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.floralwhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicFloralWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.floralwhite")]
            [Name("text.italic.floralwhite")]
            internal sealed class DiffitalicFloralWhiteFormat : ClassificationFormatDefinition{

                public DiffitalicFloralWhiteFormat() { 
					this.ForegroundColor = Colors.FloralWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- ForestGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.forestgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicForestGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.forestgreen")]
            [Name("text.italic.forestgreen")]
            internal sealed class DiffitalicForestGreenFormat : ClassificationFormatDefinition{

                public DiffitalicForestGreenFormat() { 
					this.ForegroundColor = Colors.ForestGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Fuchsia --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.fuchsia")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicFuchsiaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.fuchsia")]
            [Name("text.italic.fuchsia")]
            internal sealed class DiffitalicFuchsiaFormat : ClassificationFormatDefinition{

                public DiffitalicFuchsiaFormat() { 
					this.ForegroundColor = Colors.Fuchsia; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Gainsboro --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.gainsboro")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicGainsboroDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.gainsboro")]
            [Name("text.italic.gainsboro")]
            internal sealed class DiffitalicGainsboroFormat : ClassificationFormatDefinition{

                public DiffitalicGainsboroFormat() { 
					this.ForegroundColor = Colors.Gainsboro; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- GhostWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.ghostwhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicGhostWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.ghostwhite")]
            [Name("text.italic.ghostwhite")]
            internal sealed class DiffitalicGhostWhiteFormat : ClassificationFormatDefinition{

                public DiffitalicGhostWhiteFormat() { 
					this.ForegroundColor = Colors.GhostWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Gold --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.gold")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicGoldDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.gold")]
            [Name("text.italic.gold")]
            internal sealed class DiffitalicGoldFormat : ClassificationFormatDefinition{

                public DiffitalicGoldFormat() { 
					this.ForegroundColor = Colors.Gold; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Goldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.goldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.goldenrod")]
            [Name("text.italic.goldenrod")]
            internal sealed class DiffitalicGoldenrodFormat : ClassificationFormatDefinition{

                public DiffitalicGoldenrodFormat() { 
					this.ForegroundColor = Colors.Goldenrod; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Gray --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.gray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.gray")]
            [Name("text.italic.gray")]
            internal sealed class DiffitalicGrayFormat : ClassificationFormatDefinition{

                public DiffitalicGrayFormat() { 
					this.ForegroundColor = Colors.Gray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Green --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.green")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.green")]
            [Name("text.italic.green")]
            internal sealed class DiffitalicGreenFormat : ClassificationFormatDefinition{

                public DiffitalicGreenFormat() { 
					this.ForegroundColor = Colors.Green; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- GreenYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.greenyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicGreenYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.greenyellow")]
            [Name("text.italic.greenyellow")]
            internal sealed class DiffitalicGreenYellowFormat : ClassificationFormatDefinition{

                public DiffitalicGreenYellowFormat() { 
					this.ForegroundColor = Colors.GreenYellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Honeydew --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.honeydew")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicHoneydewDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.honeydew")]
            [Name("text.italic.honeydew")]
            internal sealed class DiffitalicHoneydewFormat : ClassificationFormatDefinition{

                public DiffitalicHoneydewFormat() { 
					this.ForegroundColor = Colors.Honeydew; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- HotPink --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.hotpink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicHotPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.hotpink")]
            [Name("text.italic.hotpink")]
            internal sealed class DiffitalicHotPinkFormat : ClassificationFormatDefinition{

                public DiffitalicHotPinkFormat() { 
					this.ForegroundColor = Colors.HotPink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- IndianRed --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.indianred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicIndianRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.indianred")]
            [Name("text.italic.indianred")]
            internal sealed class DiffitalicIndianRedFormat : ClassificationFormatDefinition{

                public DiffitalicIndianRedFormat() { 
					this.ForegroundColor = Colors.IndianRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Indigo --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.indigo")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicIndigoDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.indigo")]
            [Name("text.italic.indigo")]
            internal sealed class DiffitalicIndigoFormat : ClassificationFormatDefinition{

                public DiffitalicIndigoFormat() { 
					this.ForegroundColor = Colors.Indigo; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Ivory --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.ivory")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicIvoryDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.ivory")]
            [Name("text.italic.ivory")]
            internal sealed class DiffitalicIvoryFormat : ClassificationFormatDefinition{

                public DiffitalicIvoryFormat() { 
					this.ForegroundColor = Colors.Ivory; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Khaki --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.khaki")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicKhakiDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.khaki")]
            [Name("text.italic.khaki")]
            internal sealed class DiffitalicKhakiFormat : ClassificationFormatDefinition{

                public DiffitalicKhakiFormat() { 
					this.ForegroundColor = Colors.Khaki; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Lavender --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lavender")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLavenderDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lavender")]
            [Name("text.italic.lavender")]
            internal sealed class DiffitalicLavenderFormat : ClassificationFormatDefinition{

                public DiffitalicLavenderFormat() { 
					this.ForegroundColor = Colors.Lavender; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LavenderBlush --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lavenderblush")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLavenderBlushDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lavenderblush")]
            [Name("text.italic.lavenderblush")]
            internal sealed class DiffitalicLavenderBlushFormat : ClassificationFormatDefinition{

                public DiffitalicLavenderBlushFormat() { 
					this.ForegroundColor = Colors.LavenderBlush; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LawnGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lawngreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLawnGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lawngreen")]
            [Name("text.italic.lawngreen")]
            internal sealed class DiffitalicLawnGreenFormat : ClassificationFormatDefinition{

                public DiffitalicLawnGreenFormat() { 
					this.ForegroundColor = Colors.LawnGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LemonChiffon --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lemonchiffon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLemonChiffonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lemonchiffon")]
            [Name("text.italic.lemonchiffon")]
            internal sealed class DiffitalicLemonChiffonFormat : ClassificationFormatDefinition{

                public DiffitalicLemonChiffonFormat() { 
					this.ForegroundColor = Colors.LemonChiffon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightblue")]
            [Name("text.italic.lightblue")]
            internal sealed class DiffitalicLightBlueFormat : ClassificationFormatDefinition{

                public DiffitalicLightBlueFormat() { 
					this.ForegroundColor = Colors.LightBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightCoral --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightcoral")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightCoralDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightcoral")]
            [Name("text.italic.lightcoral")]
            internal sealed class DiffitalicLightCoralFormat : ClassificationFormatDefinition{

                public DiffitalicLightCoralFormat() { 
					this.ForegroundColor = Colors.LightCoral; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightCyan --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightcyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightcyan")]
            [Name("text.italic.lightcyan")]
            internal sealed class DiffitalicLightCyanFormat : ClassificationFormatDefinition{

                public DiffitalicLightCyanFormat() { 
					this.ForegroundColor = Colors.LightCyan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightGoldenrodYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightgoldenrodyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightGoldenrodYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightgoldenrodyellow")]
            [Name("text.italic.lightgoldenrodyellow")]
            internal sealed class DiffitalicLightGoldenrodYellowFormat : ClassificationFormatDefinition{

                public DiffitalicLightGoldenrodYellowFormat() { 
					this.ForegroundColor = Colors.LightGoldenrodYellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightGray --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightgray")]
            [Name("text.italic.lightgray")]
            internal sealed class DiffitalicLightGrayFormat : ClassificationFormatDefinition{

                public DiffitalicLightGrayFormat() { 
					this.ForegroundColor = Colors.LightGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightgreen")]
            [Name("text.italic.lightgreen")]
            internal sealed class DiffitalicLightGreenFormat : ClassificationFormatDefinition{

                public DiffitalicLightGreenFormat() { 
					this.ForegroundColor = Colors.LightGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightPink --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightpink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightpink")]
            [Name("text.italic.lightpink")]
            internal sealed class DiffitalicLightPinkFormat : ClassificationFormatDefinition{

                public DiffitalicLightPinkFormat() { 
					this.ForegroundColor = Colors.LightPink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightSalmon --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightsalmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightsalmon")]
            [Name("text.italic.lightsalmon")]
            internal sealed class DiffitalicLightSalmonFormat : ClassificationFormatDefinition{

                public DiffitalicLightSalmonFormat() { 
					this.ForegroundColor = Colors.LightSalmon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightseagreen")]
            [Name("text.italic.lightseagreen")]
            internal sealed class DiffitalicLightSeaGreenFormat : ClassificationFormatDefinition{

                public DiffitalicLightSeaGreenFormat() { 
					this.ForegroundColor = Colors.LightSeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightSkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightskyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightskyblue")]
            [Name("text.italic.lightskyblue")]
            internal sealed class DiffitalicLightSkyBlueFormat : ClassificationFormatDefinition{

                public DiffitalicLightSkyBlueFormat() { 
					this.ForegroundColor = Colors.LightSkyBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightSlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightslategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightslategray")]
            [Name("text.italic.lightslategray")]
            internal sealed class DiffitalicLightSlateGrayFormat : ClassificationFormatDefinition{

                public DiffitalicLightSlateGrayFormat() { 
					this.ForegroundColor = Colors.LightSlateGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightSteelBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightsteelblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightSteelBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightsteelblue")]
            [Name("text.italic.lightsteelblue")]
            internal sealed class DiffitalicLightSteelBlueFormat : ClassificationFormatDefinition{

                public DiffitalicLightSteelBlueFormat() { 
					this.ForegroundColor = Colors.LightSteelBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lightyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLightYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lightyellow")]
            [Name("text.italic.lightyellow")]
            internal sealed class DiffitalicLightYellowFormat : ClassificationFormatDefinition{

                public DiffitalicLightYellowFormat() { 
					this.ForegroundColor = Colors.LightYellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Lime --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.lime")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLimeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.lime")]
            [Name("text.italic.lime")]
            internal sealed class DiffitalicLimeFormat : ClassificationFormatDefinition{

                public DiffitalicLimeFormat() { 
					this.ForegroundColor = Colors.Lime; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LimeGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.limegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLimeGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.limegreen")]
            [Name("text.italic.limegreen")]
            internal sealed class DiffitalicLimeGreenFormat : ClassificationFormatDefinition{

                public DiffitalicLimeGreenFormat() { 
					this.ForegroundColor = Colors.LimeGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Linen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.linen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicLinenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.linen")]
            [Name("text.italic.linen")]
            internal sealed class DiffitalicLinenFormat : ClassificationFormatDefinition{

                public DiffitalicLinenFormat() { 
					this.ForegroundColor = Colors.Linen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Magenta --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.magenta")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMagentaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.magenta")]
            [Name("text.italic.magenta")]
            internal sealed class DiffitalicMagentaFormat : ClassificationFormatDefinition{

                public DiffitalicMagentaFormat() { 
					this.ForegroundColor = Colors.Magenta; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Maroon --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.maroon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMaroonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.maroon")]
            [Name("text.italic.maroon")]
            internal sealed class DiffitalicMaroonFormat : ClassificationFormatDefinition{

                public DiffitalicMaroonFormat() { 
					this.ForegroundColor = Colors.Maroon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumAquamarine --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mediumaquamarine")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMediumAquamarineDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mediumaquamarine")]
            [Name("text.italic.mediumaquamarine")]
            internal sealed class DiffitalicMediumAquamarineFormat : ClassificationFormatDefinition{

                public DiffitalicMediumAquamarineFormat() { 
					this.ForegroundColor = Colors.MediumAquamarine; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mediumblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMediumBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mediumblue")]
            [Name("text.italic.mediumblue")]
            internal sealed class DiffitalicMediumBlueFormat : ClassificationFormatDefinition{

                public DiffitalicMediumBlueFormat() { 
					this.ForegroundColor = Colors.MediumBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumOrchid --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mediumorchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMediumOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mediumorchid")]
            [Name("text.italic.mediumorchid")]
            internal sealed class DiffitalicMediumOrchidFormat : ClassificationFormatDefinition{

                public DiffitalicMediumOrchidFormat() { 
					this.ForegroundColor = Colors.MediumOrchid; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumPurple --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mediumpurple")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMediumPurpleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mediumpurple")]
            [Name("text.italic.mediumpurple")]
            internal sealed class DiffitalicMediumPurpleFormat : ClassificationFormatDefinition{

                public DiffitalicMediumPurpleFormat() { 
					this.ForegroundColor = Colors.MediumPurple; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mediumseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMediumSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mediumseagreen")]
            [Name("text.italic.mediumseagreen")]
            internal sealed class DiffitalicMediumSeaGreenFormat : ClassificationFormatDefinition{

                public DiffitalicMediumSeaGreenFormat() { 
					this.ForegroundColor = Colors.MediumSeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumSlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mediumslateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMediumSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mediumslateblue")]
            [Name("text.italic.mediumslateblue")]
            internal sealed class DiffitalicMediumSlateBlueFormat : ClassificationFormatDefinition{

                public DiffitalicMediumSlateBlueFormat() { 
					this.ForegroundColor = Colors.MediumSlateBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumSpringGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mediumspringgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMediumSpringGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mediumspringgreen")]
            [Name("text.italic.mediumspringgreen")]
            internal sealed class DiffitalicMediumSpringGreenFormat : ClassificationFormatDefinition{

                public DiffitalicMediumSpringGreenFormat() { 
					this.ForegroundColor = Colors.MediumSpringGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mediumturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMediumTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mediumturquoise")]
            [Name("text.italic.mediumturquoise")]
            internal sealed class DiffitalicMediumTurquoiseFormat : ClassificationFormatDefinition{

                public DiffitalicMediumTurquoiseFormat() { 
					this.ForegroundColor = Colors.MediumTurquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumVioletRed --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mediumvioletred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMediumVioletRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mediumvioletred")]
            [Name("text.italic.mediumvioletred")]
            internal sealed class DiffitalicMediumVioletRedFormat : ClassificationFormatDefinition{

                public DiffitalicMediumVioletRedFormat() { 
					this.ForegroundColor = Colors.MediumVioletRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MidnightBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.midnightblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMidnightBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.midnightblue")]
            [Name("text.italic.midnightblue")]
            internal sealed class DiffitalicMidnightBlueFormat : ClassificationFormatDefinition{

                public DiffitalicMidnightBlueFormat() { 
					this.ForegroundColor = Colors.MidnightBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MintCream --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mintcream")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMintCreamDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mintcream")]
            [Name("text.italic.mintcream")]
            internal sealed class DiffitalicMintCreamFormat : ClassificationFormatDefinition{

                public DiffitalicMintCreamFormat() { 
					this.ForegroundColor = Colors.MintCream; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MistyRose --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.mistyrose")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMistyRoseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.mistyrose")]
            [Name("text.italic.mistyrose")]
            internal sealed class DiffitalicMistyRoseFormat : ClassificationFormatDefinition{

                public DiffitalicMistyRoseFormat() { 
					this.ForegroundColor = Colors.MistyRose; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Moccasin --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.moccasin")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicMoccasinDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.moccasin")]
            [Name("text.italic.moccasin")]
            internal sealed class DiffitalicMoccasinFormat : ClassificationFormatDefinition{

                public DiffitalicMoccasinFormat() { 
					this.ForegroundColor = Colors.Moccasin; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- NavajoWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.navajowhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicNavajoWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.navajowhite")]
            [Name("text.italic.navajowhite")]
            internal sealed class DiffitalicNavajoWhiteFormat : ClassificationFormatDefinition{

                public DiffitalicNavajoWhiteFormat() { 
					this.ForegroundColor = Colors.NavajoWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Navy --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.navy")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicNavyDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.navy")]
            [Name("text.italic.navy")]
            internal sealed class DiffitalicNavyFormat : ClassificationFormatDefinition{

                public DiffitalicNavyFormat() { 
					this.ForegroundColor = Colors.Navy; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- OldLace --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.oldlace")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicOldLaceDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.oldlace")]
            [Name("text.italic.oldlace")]
            internal sealed class DiffitalicOldLaceFormat : ClassificationFormatDefinition{

                public DiffitalicOldLaceFormat() { 
					this.ForegroundColor = Colors.OldLace; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Olive --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.olive")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicOliveDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.olive")]
            [Name("text.italic.olive")]
            internal sealed class DiffitalicOliveFormat : ClassificationFormatDefinition{

                public DiffitalicOliveFormat() { 
					this.ForegroundColor = Colors.Olive; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- OliveDrab --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.olivedrab")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicOliveDrabDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.olivedrab")]
            [Name("text.italic.olivedrab")]
            internal sealed class DiffitalicOliveDrabFormat : ClassificationFormatDefinition{

                public DiffitalicOliveDrabFormat() { 
					this.ForegroundColor = Colors.OliveDrab; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Orange --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.orange")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicOrangeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.orange")]
            [Name("text.italic.orange")]
            internal sealed class DiffitalicOrangeFormat : ClassificationFormatDefinition{

                public DiffitalicOrangeFormat() { 
					this.ForegroundColor = Colors.Orange; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- OrangeRed --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.orangered")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicOrangeRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.orangered")]
            [Name("text.italic.orangered")]
            internal sealed class DiffitalicOrangeRedFormat : ClassificationFormatDefinition{

                public DiffitalicOrangeRedFormat() { 
					this.ForegroundColor = Colors.OrangeRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Orchid --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.orchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.orchid")]
            [Name("text.italic.orchid")]
            internal sealed class DiffitalicOrchidFormat : ClassificationFormatDefinition{

                public DiffitalicOrchidFormat() { 
					this.ForegroundColor = Colors.Orchid; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PaleGoldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.palegoldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPaleGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.palegoldenrod")]
            [Name("text.italic.palegoldenrod")]
            internal sealed class DiffitalicPaleGoldenrodFormat : ClassificationFormatDefinition{

                public DiffitalicPaleGoldenrodFormat() { 
					this.ForegroundColor = Colors.PaleGoldenrod; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PaleGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.palegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPaleGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.palegreen")]
            [Name("text.italic.palegreen")]
            internal sealed class DiffitalicPaleGreenFormat : ClassificationFormatDefinition{

                public DiffitalicPaleGreenFormat() { 
					this.ForegroundColor = Colors.PaleGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PaleTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.paleturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPaleTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.paleturquoise")]
            [Name("text.italic.paleturquoise")]
            internal sealed class DiffitalicPaleTurquoiseFormat : ClassificationFormatDefinition{

                public DiffitalicPaleTurquoiseFormat() { 
					this.ForegroundColor = Colors.PaleTurquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PaleVioletRed --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.palevioletred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPaleVioletRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.palevioletred")]
            [Name("text.italic.palevioletred")]
            internal sealed class DiffitalicPaleVioletRedFormat : ClassificationFormatDefinition{

                public DiffitalicPaleVioletRedFormat() { 
					this.ForegroundColor = Colors.PaleVioletRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PapayaWhip --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.papayawhip")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPapayaWhipDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.papayawhip")]
            [Name("text.italic.papayawhip")]
            internal sealed class DiffitalicPapayaWhipFormat : ClassificationFormatDefinition{

                public DiffitalicPapayaWhipFormat() { 
					this.ForegroundColor = Colors.PapayaWhip; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PeachPuff --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.peachpuff")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPeachPuffDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.peachpuff")]
            [Name("text.italic.peachpuff")]
            internal sealed class DiffitalicPeachPuffFormat : ClassificationFormatDefinition{

                public DiffitalicPeachPuffFormat() { 
					this.ForegroundColor = Colors.PeachPuff; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Peru --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.peru")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPeruDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.peru")]
            [Name("text.italic.peru")]
            internal sealed class DiffitalicPeruFormat : ClassificationFormatDefinition{

                public DiffitalicPeruFormat() { 
					this.ForegroundColor = Colors.Peru; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Pink --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.pink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.pink")]
            [Name("text.italic.pink")]
            internal sealed class DiffitalicPinkFormat : ClassificationFormatDefinition{

                public DiffitalicPinkFormat() { 
					this.ForegroundColor = Colors.Pink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Plum --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.plum")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPlumDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.plum")]
            [Name("text.italic.plum")]
            internal sealed class DiffitalicPlumFormat : ClassificationFormatDefinition{

                public DiffitalicPlumFormat() { 
					this.ForegroundColor = Colors.Plum; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PowderBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.powderblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPowderBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.powderblue")]
            [Name("text.italic.powderblue")]
            internal sealed class DiffitalicPowderBlueFormat : ClassificationFormatDefinition{

                public DiffitalicPowderBlueFormat() { 
					this.ForegroundColor = Colors.PowderBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Purple --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.purple")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicPurpleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.purple")]
            [Name("text.italic.purple")]
            internal sealed class DiffitalicPurpleFormat : ClassificationFormatDefinition{

                public DiffitalicPurpleFormat() { 
					this.ForegroundColor = Colors.Purple; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Red --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.red")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.red")]
            [Name("text.italic.red")]
            internal sealed class DiffitalicRedFormat : ClassificationFormatDefinition{

                public DiffitalicRedFormat() { 
					this.ForegroundColor = Colors.Red; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- RosyBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.rosybrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicRosyBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.rosybrown")]
            [Name("text.italic.rosybrown")]
            internal sealed class DiffitalicRosyBrownFormat : ClassificationFormatDefinition{

                public DiffitalicRosyBrownFormat() { 
					this.ForegroundColor = Colors.RosyBrown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- RoyalBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.royalblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicRoyalBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.royalblue")]
            [Name("text.italic.royalblue")]
            internal sealed class DiffitalicRoyalBlueFormat : ClassificationFormatDefinition{

                public DiffitalicRoyalBlueFormat() { 
					this.ForegroundColor = Colors.RoyalBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SaddleBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.saddlebrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSaddleBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.saddlebrown")]
            [Name("text.italic.saddlebrown")]
            internal sealed class DiffitalicSaddleBrownFormat : ClassificationFormatDefinition{

                public DiffitalicSaddleBrownFormat() { 
					this.ForegroundColor = Colors.SaddleBrown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Salmon --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.salmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.salmon")]
            [Name("text.italic.salmon")]
            internal sealed class DiffitalicSalmonFormat : ClassificationFormatDefinition{

                public DiffitalicSalmonFormat() { 
					this.ForegroundColor = Colors.Salmon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SandyBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.sandybrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSandyBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.sandybrown")]
            [Name("text.italic.sandybrown")]
            internal sealed class DiffitalicSandyBrownFormat : ClassificationFormatDefinition{

                public DiffitalicSandyBrownFormat() { 
					this.ForegroundColor = Colors.SandyBrown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.seagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.seagreen")]
            [Name("text.italic.seagreen")]
            internal sealed class DiffitalicSeaGreenFormat : ClassificationFormatDefinition{

                public DiffitalicSeaGreenFormat() { 
					this.ForegroundColor = Colors.SeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SeaShell --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.seashell")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSeaShellDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.seashell")]
            [Name("text.italic.seashell")]
            internal sealed class DiffitalicSeaShellFormat : ClassificationFormatDefinition{

                public DiffitalicSeaShellFormat() { 
					this.ForegroundColor = Colors.SeaShell; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Sienna --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.sienna")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSiennaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.sienna")]
            [Name("text.italic.sienna")]
            internal sealed class DiffitalicSiennaFormat : ClassificationFormatDefinition{

                public DiffitalicSiennaFormat() { 
					this.ForegroundColor = Colors.Sienna; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Silver --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.silver")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSilverDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.silver")]
            [Name("text.italic.silver")]
            internal sealed class DiffitalicSilverFormat : ClassificationFormatDefinition{

                public DiffitalicSilverFormat() { 
					this.ForegroundColor = Colors.Silver; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.skyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.skyblue")]
            [Name("text.italic.skyblue")]
            internal sealed class DiffitalicSkyBlueFormat : ClassificationFormatDefinition{

                public DiffitalicSkyBlueFormat() { 
					this.ForegroundColor = Colors.SkyBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.slateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.slateblue")]
            [Name("text.italic.slateblue")]
            internal sealed class DiffitalicSlateBlueFormat : ClassificationFormatDefinition{

                public DiffitalicSlateBlueFormat() { 
					this.ForegroundColor = Colors.SlateBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.slategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.slategray")]
            [Name("text.italic.slategray")]
            internal sealed class DiffitalicSlateGrayFormat : ClassificationFormatDefinition{

                public DiffitalicSlateGrayFormat() { 
					this.ForegroundColor = Colors.SlateGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Snow --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.snow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSnowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.snow")]
            [Name("text.italic.snow")]
            internal sealed class DiffitalicSnowFormat : ClassificationFormatDefinition{

                public DiffitalicSnowFormat() { 
					this.ForegroundColor = Colors.Snow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SpringGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.springgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSpringGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.springgreen")]
            [Name("text.italic.springgreen")]
            internal sealed class DiffitalicSpringGreenFormat : ClassificationFormatDefinition{

                public DiffitalicSpringGreenFormat() { 
					this.ForegroundColor = Colors.SpringGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SteelBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.steelblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicSteelBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.steelblue")]
            [Name("text.italic.steelblue")]
            internal sealed class DiffitalicSteelBlueFormat : ClassificationFormatDefinition{

                public DiffitalicSteelBlueFormat() { 
					this.ForegroundColor = Colors.SteelBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Tan --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.tan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicTanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.tan")]
            [Name("text.italic.tan")]
            internal sealed class DiffitalicTanFormat : ClassificationFormatDefinition{

                public DiffitalicTanFormat() { 
					this.ForegroundColor = Colors.Tan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Teal --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.teal")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicTealDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.teal")]
            [Name("text.italic.teal")]
            internal sealed class DiffitalicTealFormat : ClassificationFormatDefinition{

                public DiffitalicTealFormat() { 
					this.ForegroundColor = Colors.Teal; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Thistle --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.thistle")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicThistleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.thistle")]
            [Name("text.italic.thistle")]
            internal sealed class DiffitalicThistleFormat : ClassificationFormatDefinition{

                public DiffitalicThistleFormat() { 
					this.ForegroundColor = Colors.Thistle; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Tomato --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.tomato")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicTomatoDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.tomato")]
            [Name("text.italic.tomato")]
            internal sealed class DiffitalicTomatoFormat : ClassificationFormatDefinition{

                public DiffitalicTomatoFormat() { 
					this.ForegroundColor = Colors.Tomato; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Transparent --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.transparent")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicTransparentDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.transparent")]
            [Name("text.italic.transparent")]
            internal sealed class DiffitalicTransparentFormat : ClassificationFormatDefinition{

                public DiffitalicTransparentFormat() { 
					this.ForegroundColor = Colors.Transparent; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Turquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.turquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.turquoise")]
            [Name("text.italic.turquoise")]
            internal sealed class DiffitalicTurquoiseFormat : ClassificationFormatDefinition{

                public DiffitalicTurquoiseFormat() { 
					this.ForegroundColor = Colors.Turquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Violet --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.violet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.violet")]
            [Name("text.italic.violet")]
            internal sealed class DiffitalicVioletFormat : ClassificationFormatDefinition{

                public DiffitalicVioletFormat() { 
					this.ForegroundColor = Colors.Violet; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Wheat --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.wheat")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicWheatDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.wheat")]
            [Name("text.italic.wheat")]
            internal sealed class DiffitalicWheatFormat : ClassificationFormatDefinition{

                public DiffitalicWheatFormat() { 
					this.ForegroundColor = Colors.Wheat; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- White --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.white")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.white")]
            [Name("text.italic.white")]
            internal sealed class DiffitalicWhiteFormat : ClassificationFormatDefinition{

                public DiffitalicWhiteFormat() { 
					this.ForegroundColor = Colors.White; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- WhiteSmoke --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.whitesmoke")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicWhiteSmokeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.whitesmoke")]
            [Name("text.italic.whitesmoke")]
            internal sealed class DiffitalicWhiteSmokeFormat : ClassificationFormatDefinition{

                public DiffitalicWhiteSmokeFormat() { 
					this.ForegroundColor = Colors.WhiteSmoke; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Yellow --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.yellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.yellow")]
            [Name("text.italic.yellow")]
            internal sealed class DiffitalicYellowFormat : ClassificationFormatDefinition{

                public DiffitalicYellowFormat() { 
					this.ForegroundColor = Colors.Yellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
                    
            /* -- YellowGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.italic.yellowgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffitalicYellowGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.italic.yellowgreen")]
            [Name("text.italic.yellowgreen")]
            internal sealed class DiffitalicYellowGreenFormat : ClassificationFormatDefinition{

                public DiffitalicYellowGreenFormat() { 
					this.ForegroundColor = Colors.YellowGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsItalic = true;
				}
            }
        


    }
}