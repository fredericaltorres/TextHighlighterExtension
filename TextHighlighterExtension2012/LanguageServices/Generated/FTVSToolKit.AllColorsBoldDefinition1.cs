
using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities; 
   
namespace FTVSToolKit { //AA  aa 

    internal static class AllColorsBoldDefinition { // DiffClassificationDefinitions
	
                    
            /* -- AliceBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.aliceblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldAliceBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.aliceblue")]
            [Name("text.bold.aliceblue")]
            internal sealed class DiffboldAliceBlueFormat : ClassificationFormatDefinition{

                public DiffboldAliceBlueFormat() { 
					this.ForegroundColor = Colors.AliceBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- AntiqueWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.antiquewhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldAntiqueWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.antiquewhite")]
            [Name("text.bold.antiquewhite")]
            internal sealed class DiffboldAntiqueWhiteFormat : ClassificationFormatDefinition{

                public DiffboldAntiqueWhiteFormat() { 
					this.ForegroundColor = Colors.AntiqueWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Aqua --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.aqua")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldAquaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.aqua")]
            [Name("text.bold.aqua")]
            internal sealed class DiffboldAquaFormat : ClassificationFormatDefinition{

                public DiffboldAquaFormat() { 
					this.ForegroundColor = Colors.Aqua; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Aquamarine --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.aquamarine")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldAquamarineDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.aquamarine")]
            [Name("text.bold.aquamarine")]
            internal sealed class DiffboldAquamarineFormat : ClassificationFormatDefinition{

                public DiffboldAquamarineFormat() { 
					this.ForegroundColor = Colors.Aquamarine; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Azure --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.azure")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldAzureDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.azure")]
            [Name("text.bold.azure")]
            internal sealed class DiffboldAzureFormat : ClassificationFormatDefinition{

                public DiffboldAzureFormat() { 
					this.ForegroundColor = Colors.Azure; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Beige --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.beige")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldBeigeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.beige")]
            [Name("text.bold.beige")]
            internal sealed class DiffboldBeigeFormat : ClassificationFormatDefinition{

                public DiffboldBeigeFormat() { 
					this.ForegroundColor = Colors.Beige; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Bisque --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.bisque")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldBisqueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.bisque")]
            [Name("text.bold.bisque")]
            internal sealed class DiffboldBisqueFormat : ClassificationFormatDefinition{

                public DiffboldBisqueFormat() { 
					this.ForegroundColor = Colors.Bisque; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Black --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.black")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldBlackDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.black")]
            [Name("text.bold.black")]
            internal sealed class DiffboldBlackFormat : ClassificationFormatDefinition{

                public DiffboldBlackFormat() { 
					this.ForegroundColor = Colors.Black; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- BlanchedAlmond --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.blanchedalmond")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldBlanchedAlmondDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.blanchedalmond")]
            [Name("text.bold.blanchedalmond")]
            internal sealed class DiffboldBlanchedAlmondFormat : ClassificationFormatDefinition{

                public DiffboldBlanchedAlmondFormat() { 
					this.ForegroundColor = Colors.BlanchedAlmond; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Blue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.blue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.blue")]
            [Name("text.bold.blue")]
            internal sealed class DiffboldBlueFormat : ClassificationFormatDefinition{

                public DiffboldBlueFormat() { 
					this.ForegroundColor = Colors.Blue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- BlueViolet --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.blueviolet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldBlueVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.blueviolet")]
            [Name("text.bold.blueviolet")]
            internal sealed class DiffboldBlueVioletFormat : ClassificationFormatDefinition{

                public DiffboldBlueVioletFormat() { 
					this.ForegroundColor = Colors.BlueViolet; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Brown --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.brown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.brown")]
            [Name("text.bold.brown")]
            internal sealed class DiffboldBrownFormat : ClassificationFormatDefinition{

                public DiffboldBrownFormat() { 
					this.ForegroundColor = Colors.Brown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- BurlyWood --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.burlywood")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldBurlyWoodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.burlywood")]
            [Name("text.bold.burlywood")]
            internal sealed class DiffboldBurlyWoodFormat : ClassificationFormatDefinition{

                public DiffboldBurlyWoodFormat() { 
					this.ForegroundColor = Colors.BurlyWood; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- CadetBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.cadetblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldCadetBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.cadetblue")]
            [Name("text.bold.cadetblue")]
            internal sealed class DiffboldCadetBlueFormat : ClassificationFormatDefinition{

                public DiffboldCadetBlueFormat() { 
					this.ForegroundColor = Colors.CadetBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Chartreuse --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.chartreuse")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldChartreuseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.chartreuse")]
            [Name("text.bold.chartreuse")]
            internal sealed class DiffboldChartreuseFormat : ClassificationFormatDefinition{

                public DiffboldChartreuseFormat() { 
					this.ForegroundColor = Colors.Chartreuse; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Chocolate --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.chocolate")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldChocolateDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.chocolate")]
            [Name("text.bold.chocolate")]
            internal sealed class DiffboldChocolateFormat : ClassificationFormatDefinition{

                public DiffboldChocolateFormat() { 
					this.ForegroundColor = Colors.Chocolate; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Coral --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.coral")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldCoralDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.coral")]
            [Name("text.bold.coral")]
            internal sealed class DiffboldCoralFormat : ClassificationFormatDefinition{

                public DiffboldCoralFormat() { 
					this.ForegroundColor = Colors.Coral; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- CornflowerBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.cornflowerblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldCornflowerBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.cornflowerblue")]
            [Name("text.bold.cornflowerblue")]
            internal sealed class DiffboldCornflowerBlueFormat : ClassificationFormatDefinition{

                public DiffboldCornflowerBlueFormat() { 
					this.ForegroundColor = Colors.CornflowerBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Cornsilk --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.cornsilk")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldCornsilkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.cornsilk")]
            [Name("text.bold.cornsilk")]
            internal sealed class DiffboldCornsilkFormat : ClassificationFormatDefinition{

                public DiffboldCornsilkFormat() { 
					this.ForegroundColor = Colors.Cornsilk; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Crimson --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.crimson")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldCrimsonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.crimson")]
            [Name("text.bold.crimson")]
            internal sealed class DiffboldCrimsonFormat : ClassificationFormatDefinition{

                public DiffboldCrimsonFormat() { 
					this.ForegroundColor = Colors.Crimson; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Cyan --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.cyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.cyan")]
            [Name("text.bold.cyan")]
            internal sealed class DiffboldCyanFormat : ClassificationFormatDefinition{

                public DiffboldCyanFormat() { 
					this.ForegroundColor = Colors.Cyan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkblue")]
            [Name("text.bold.darkblue")]
            internal sealed class DiffboldDarkBlueFormat : ClassificationFormatDefinition{

                public DiffboldDarkBlueFormat() { 
					this.ForegroundColor = Colors.DarkBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkCyan --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkcyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkcyan")]
            [Name("text.bold.darkcyan")]
            internal sealed class DiffboldDarkCyanFormat : ClassificationFormatDefinition{

                public DiffboldDarkCyanFormat() { 
					this.ForegroundColor = Colors.DarkCyan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkGoldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkgoldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkgoldenrod")]
            [Name("text.bold.darkgoldenrod")]
            internal sealed class DiffboldDarkGoldenrodFormat : ClassificationFormatDefinition{

                public DiffboldDarkGoldenrodFormat() { 
					this.ForegroundColor = Colors.DarkGoldenrod; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkgray")]
            [Name("text.bold.darkgray")]
            internal sealed class DiffboldDarkGrayFormat : ClassificationFormatDefinition{

                public DiffboldDarkGrayFormat() { 
					this.ForegroundColor = Colors.DarkGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkgreen")]
            [Name("text.bold.darkgreen")]
            internal sealed class DiffboldDarkGreenFormat : ClassificationFormatDefinition{

                public DiffboldDarkGreenFormat() { 
					this.ForegroundColor = Colors.DarkGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkKhaki --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkkhaki")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkKhakiDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkkhaki")]
            [Name("text.bold.darkkhaki")]
            internal sealed class DiffboldDarkKhakiFormat : ClassificationFormatDefinition{

                public DiffboldDarkKhakiFormat() { 
					this.ForegroundColor = Colors.DarkKhaki; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkMagenta --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkmagenta")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkMagentaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkmagenta")]
            [Name("text.bold.darkmagenta")]
            internal sealed class DiffboldDarkMagentaFormat : ClassificationFormatDefinition{

                public DiffboldDarkMagentaFormat() { 
					this.ForegroundColor = Colors.DarkMagenta; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkOliveGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkolivegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkOliveGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkolivegreen")]
            [Name("text.bold.darkolivegreen")]
            internal sealed class DiffboldDarkOliveGreenFormat : ClassificationFormatDefinition{

                public DiffboldDarkOliveGreenFormat() { 
					this.ForegroundColor = Colors.DarkOliveGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkOrange --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkorange")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkOrangeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkorange")]
            [Name("text.bold.darkorange")]
            internal sealed class DiffboldDarkOrangeFormat : ClassificationFormatDefinition{

                public DiffboldDarkOrangeFormat() { 
					this.ForegroundColor = Colors.DarkOrange; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkOrchid --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkorchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkorchid")]
            [Name("text.bold.darkorchid")]
            internal sealed class DiffboldDarkOrchidFormat : ClassificationFormatDefinition{

                public DiffboldDarkOrchidFormat() { 
					this.ForegroundColor = Colors.DarkOrchid; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkRed --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkred")]
            [Name("text.bold.darkred")]
            internal sealed class DiffboldDarkRedFormat : ClassificationFormatDefinition{

                public DiffboldDarkRedFormat() { 
					this.ForegroundColor = Colors.DarkRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkSalmon --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darksalmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darksalmon")]
            [Name("text.bold.darksalmon")]
            internal sealed class DiffboldDarkSalmonFormat : ClassificationFormatDefinition{

                public DiffboldDarkSalmonFormat() { 
					this.ForegroundColor = Colors.DarkSalmon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkseagreen")]
            [Name("text.bold.darkseagreen")]
            internal sealed class DiffboldDarkSeaGreenFormat : ClassificationFormatDefinition{

                public DiffboldDarkSeaGreenFormat() { 
					this.ForegroundColor = Colors.DarkSeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkSlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkslateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkslateblue")]
            [Name("text.bold.darkslateblue")]
            internal sealed class DiffboldDarkSlateBlueFormat : ClassificationFormatDefinition{

                public DiffboldDarkSlateBlueFormat() { 
					this.ForegroundColor = Colors.DarkSlateBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkSlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkslategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkslategray")]
            [Name("text.bold.darkslategray")]
            internal sealed class DiffboldDarkSlateGrayFormat : ClassificationFormatDefinition{

                public DiffboldDarkSlateGrayFormat() { 
					this.ForegroundColor = Colors.DarkSlateGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkturquoise")]
            [Name("text.bold.darkturquoise")]
            internal sealed class DiffboldDarkTurquoiseFormat : ClassificationFormatDefinition{

                public DiffboldDarkTurquoiseFormat() { 
					this.ForegroundColor = Colors.DarkTurquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DarkViolet --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.darkviolet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDarkVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.darkviolet")]
            [Name("text.bold.darkviolet")]
            internal sealed class DiffboldDarkVioletFormat : ClassificationFormatDefinition{

                public DiffboldDarkVioletFormat() { 
					this.ForegroundColor = Colors.DarkViolet; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DeepPink --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.deeppink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDeepPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.deeppink")]
            [Name("text.bold.deeppink")]
            internal sealed class DiffboldDeepPinkFormat : ClassificationFormatDefinition{

                public DiffboldDeepPinkFormat() { 
					this.ForegroundColor = Colors.DeepPink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DeepSkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.deepskyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDeepSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.deepskyblue")]
            [Name("text.bold.deepskyblue")]
            internal sealed class DiffboldDeepSkyBlueFormat : ClassificationFormatDefinition{

                public DiffboldDeepSkyBlueFormat() { 
					this.ForegroundColor = Colors.DeepSkyBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DimGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.dimgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDimGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.dimgray")]
            [Name("text.bold.dimgray")]
            internal sealed class DiffboldDimGrayFormat : ClassificationFormatDefinition{

                public DiffboldDimGrayFormat() { 
					this.ForegroundColor = Colors.DimGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- DodgerBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.dodgerblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldDodgerBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.dodgerblue")]
            [Name("text.bold.dodgerblue")]
            internal sealed class DiffboldDodgerBlueFormat : ClassificationFormatDefinition{

                public DiffboldDodgerBlueFormat() { 
					this.ForegroundColor = Colors.DodgerBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Firebrick --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.firebrick")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldFirebrickDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.firebrick")]
            [Name("text.bold.firebrick")]
            internal sealed class DiffboldFirebrickFormat : ClassificationFormatDefinition{

                public DiffboldFirebrickFormat() { 
					this.ForegroundColor = Colors.Firebrick; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- FloralWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.floralwhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldFloralWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.floralwhite")]
            [Name("text.bold.floralwhite")]
            internal sealed class DiffboldFloralWhiteFormat : ClassificationFormatDefinition{

                public DiffboldFloralWhiteFormat() { 
					this.ForegroundColor = Colors.FloralWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- ForestGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.forestgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldForestGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.forestgreen")]
            [Name("text.bold.forestgreen")]
            internal sealed class DiffboldForestGreenFormat : ClassificationFormatDefinition{

                public DiffboldForestGreenFormat() { 
					this.ForegroundColor = Colors.ForestGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Fuchsia --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.fuchsia")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldFuchsiaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.fuchsia")]
            [Name("text.bold.fuchsia")]
            internal sealed class DiffboldFuchsiaFormat : ClassificationFormatDefinition{

                public DiffboldFuchsiaFormat() { 
					this.ForegroundColor = Colors.Fuchsia; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Gainsboro --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.gainsboro")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldGainsboroDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.gainsboro")]
            [Name("text.bold.gainsboro")]
            internal sealed class DiffboldGainsboroFormat : ClassificationFormatDefinition{

                public DiffboldGainsboroFormat() { 
					this.ForegroundColor = Colors.Gainsboro; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- GhostWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.ghostwhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldGhostWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.ghostwhite")]
            [Name("text.bold.ghostwhite")]
            internal sealed class DiffboldGhostWhiteFormat : ClassificationFormatDefinition{

                public DiffboldGhostWhiteFormat() { 
					this.ForegroundColor = Colors.GhostWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Gold --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.gold")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldGoldDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.gold")]
            [Name("text.bold.gold")]
            internal sealed class DiffboldGoldFormat : ClassificationFormatDefinition{

                public DiffboldGoldFormat() { 
					this.ForegroundColor = Colors.Gold; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Goldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.goldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.goldenrod")]
            [Name("text.bold.goldenrod")]
            internal sealed class DiffboldGoldenrodFormat : ClassificationFormatDefinition{

                public DiffboldGoldenrodFormat() { 
					this.ForegroundColor = Colors.Goldenrod; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Gray --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.gray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.gray")]
            [Name("text.bold.gray")]
            internal sealed class DiffboldGrayFormat : ClassificationFormatDefinition{

                public DiffboldGrayFormat() { 
					this.ForegroundColor = Colors.Gray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Green --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.green")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.green")]
            [Name("text.bold.green")]
            internal sealed class DiffboldGreenFormat : ClassificationFormatDefinition{

                public DiffboldGreenFormat() { 
					this.ForegroundColor = Colors.Green; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- GreenYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.greenyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldGreenYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.greenyellow")]
            [Name("text.bold.greenyellow")]
            internal sealed class DiffboldGreenYellowFormat : ClassificationFormatDefinition{

                public DiffboldGreenYellowFormat() { 
					this.ForegroundColor = Colors.GreenYellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Honeydew --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.honeydew")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldHoneydewDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.honeydew")]
            [Name("text.bold.honeydew")]
            internal sealed class DiffboldHoneydewFormat : ClassificationFormatDefinition{

                public DiffboldHoneydewFormat() { 
					this.ForegroundColor = Colors.Honeydew; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- HotPink --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.hotpink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldHotPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.hotpink")]
            [Name("text.bold.hotpink")]
            internal sealed class DiffboldHotPinkFormat : ClassificationFormatDefinition{

                public DiffboldHotPinkFormat() { 
					this.ForegroundColor = Colors.HotPink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- IndianRed --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.indianred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldIndianRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.indianred")]
            [Name("text.bold.indianred")]
            internal sealed class DiffboldIndianRedFormat : ClassificationFormatDefinition{

                public DiffboldIndianRedFormat() { 
					this.ForegroundColor = Colors.IndianRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Indigo --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.indigo")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldIndigoDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.indigo")]
            [Name("text.bold.indigo")]
            internal sealed class DiffboldIndigoFormat : ClassificationFormatDefinition{

                public DiffboldIndigoFormat() { 
					this.ForegroundColor = Colors.Indigo; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Ivory --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.ivory")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldIvoryDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.ivory")]
            [Name("text.bold.ivory")]
            internal sealed class DiffboldIvoryFormat : ClassificationFormatDefinition{

                public DiffboldIvoryFormat() { 
					this.ForegroundColor = Colors.Ivory; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Khaki --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.khaki")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldKhakiDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.khaki")]
            [Name("text.bold.khaki")]
            internal sealed class DiffboldKhakiFormat : ClassificationFormatDefinition{

                public DiffboldKhakiFormat() { 
					this.ForegroundColor = Colors.Khaki; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Lavender --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lavender")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLavenderDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lavender")]
            [Name("text.bold.lavender")]
            internal sealed class DiffboldLavenderFormat : ClassificationFormatDefinition{

                public DiffboldLavenderFormat() { 
					this.ForegroundColor = Colors.Lavender; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LavenderBlush --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lavenderblush")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLavenderBlushDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lavenderblush")]
            [Name("text.bold.lavenderblush")]
            internal sealed class DiffboldLavenderBlushFormat : ClassificationFormatDefinition{

                public DiffboldLavenderBlushFormat() { 
					this.ForegroundColor = Colors.LavenderBlush; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LawnGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lawngreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLawnGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lawngreen")]
            [Name("text.bold.lawngreen")]
            internal sealed class DiffboldLawnGreenFormat : ClassificationFormatDefinition{

                public DiffboldLawnGreenFormat() { 
					this.ForegroundColor = Colors.LawnGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LemonChiffon --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lemonchiffon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLemonChiffonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lemonchiffon")]
            [Name("text.bold.lemonchiffon")]
            internal sealed class DiffboldLemonChiffonFormat : ClassificationFormatDefinition{

                public DiffboldLemonChiffonFormat() { 
					this.ForegroundColor = Colors.LemonChiffon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightblue")]
            [Name("text.bold.lightblue")]
            internal sealed class DiffboldLightBlueFormat : ClassificationFormatDefinition{

                public DiffboldLightBlueFormat() { 
					this.ForegroundColor = Colors.LightBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightCoral --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightcoral")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightCoralDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightcoral")]
            [Name("text.bold.lightcoral")]
            internal sealed class DiffboldLightCoralFormat : ClassificationFormatDefinition{

                public DiffboldLightCoralFormat() { 
					this.ForegroundColor = Colors.LightCoral; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightCyan --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightcyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightcyan")]
            [Name("text.bold.lightcyan")]
            internal sealed class DiffboldLightCyanFormat : ClassificationFormatDefinition{

                public DiffboldLightCyanFormat() { 
					this.ForegroundColor = Colors.LightCyan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightGoldenrodYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightgoldenrodyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightGoldenrodYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightgoldenrodyellow")]
            [Name("text.bold.lightgoldenrodyellow")]
            internal sealed class DiffboldLightGoldenrodYellowFormat : ClassificationFormatDefinition{

                public DiffboldLightGoldenrodYellowFormat() { 
					this.ForegroundColor = Colors.LightGoldenrodYellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightgray")]
            [Name("text.bold.lightgray")]
            internal sealed class DiffboldLightGrayFormat : ClassificationFormatDefinition{

                public DiffboldLightGrayFormat() { 
					this.ForegroundColor = Colors.LightGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightgreen")]
            [Name("text.bold.lightgreen")]
            internal sealed class DiffboldLightGreenFormat : ClassificationFormatDefinition{

                public DiffboldLightGreenFormat() { 
					this.ForegroundColor = Colors.LightGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightPink --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightpink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightpink")]
            [Name("text.bold.lightpink")]
            internal sealed class DiffboldLightPinkFormat : ClassificationFormatDefinition{

                public DiffboldLightPinkFormat() { 
					this.ForegroundColor = Colors.LightPink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightSalmon --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightsalmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightsalmon")]
            [Name("text.bold.lightsalmon")]
            internal sealed class DiffboldLightSalmonFormat : ClassificationFormatDefinition{

                public DiffboldLightSalmonFormat() { 
					this.ForegroundColor = Colors.LightSalmon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightseagreen")]
            [Name("text.bold.lightseagreen")]
            internal sealed class DiffboldLightSeaGreenFormat : ClassificationFormatDefinition{

                public DiffboldLightSeaGreenFormat() { 
					this.ForegroundColor = Colors.LightSeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightSkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightskyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightskyblue")]
            [Name("text.bold.lightskyblue")]
            internal sealed class DiffboldLightSkyBlueFormat : ClassificationFormatDefinition{

                public DiffboldLightSkyBlueFormat() { 
					this.ForegroundColor = Colors.LightSkyBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightSlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightslategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightslategray")]
            [Name("text.bold.lightslategray")]
            internal sealed class DiffboldLightSlateGrayFormat : ClassificationFormatDefinition{

                public DiffboldLightSlateGrayFormat() { 
					this.ForegroundColor = Colors.LightSlateGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightSteelBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightsteelblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightSteelBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightsteelblue")]
            [Name("text.bold.lightsteelblue")]
            internal sealed class DiffboldLightSteelBlueFormat : ClassificationFormatDefinition{

                public DiffboldLightSteelBlueFormat() { 
					this.ForegroundColor = Colors.LightSteelBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LightYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lightyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLightYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lightyellow")]
            [Name("text.bold.lightyellow")]
            internal sealed class DiffboldLightYellowFormat : ClassificationFormatDefinition{

                public DiffboldLightYellowFormat() { 
					this.ForegroundColor = Colors.LightYellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Lime --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.lime")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLimeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.lime")]
            [Name("text.bold.lime")]
            internal sealed class DiffboldLimeFormat : ClassificationFormatDefinition{

                public DiffboldLimeFormat() { 
					this.ForegroundColor = Colors.Lime; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- LimeGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.limegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLimeGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.limegreen")]
            [Name("text.bold.limegreen")]
            internal sealed class DiffboldLimeGreenFormat : ClassificationFormatDefinition{

                public DiffboldLimeGreenFormat() { 
					this.ForegroundColor = Colors.LimeGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Linen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.linen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldLinenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.linen")]
            [Name("text.bold.linen")]
            internal sealed class DiffboldLinenFormat : ClassificationFormatDefinition{

                public DiffboldLinenFormat() { 
					this.ForegroundColor = Colors.Linen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Magenta --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.magenta")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMagentaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.magenta")]
            [Name("text.bold.magenta")]
            internal sealed class DiffboldMagentaFormat : ClassificationFormatDefinition{

                public DiffboldMagentaFormat() { 
					this.ForegroundColor = Colors.Magenta; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Maroon --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.maroon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMaroonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.maroon")]
            [Name("text.bold.maroon")]
            internal sealed class DiffboldMaroonFormat : ClassificationFormatDefinition{

                public DiffboldMaroonFormat() { 
					this.ForegroundColor = Colors.Maroon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MediumAquamarine --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mediumaquamarine")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMediumAquamarineDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mediumaquamarine")]
            [Name("text.bold.mediumaquamarine")]
            internal sealed class DiffboldMediumAquamarineFormat : ClassificationFormatDefinition{

                public DiffboldMediumAquamarineFormat() { 
					this.ForegroundColor = Colors.MediumAquamarine; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MediumBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mediumblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMediumBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mediumblue")]
            [Name("text.bold.mediumblue")]
            internal sealed class DiffboldMediumBlueFormat : ClassificationFormatDefinition{

                public DiffboldMediumBlueFormat() { 
					this.ForegroundColor = Colors.MediumBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MediumOrchid --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mediumorchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMediumOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mediumorchid")]
            [Name("text.bold.mediumorchid")]
            internal sealed class DiffboldMediumOrchidFormat : ClassificationFormatDefinition{

                public DiffboldMediumOrchidFormat() { 
					this.ForegroundColor = Colors.MediumOrchid; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MediumPurple --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mediumpurple")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMediumPurpleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mediumpurple")]
            [Name("text.bold.mediumpurple")]
            internal sealed class DiffboldMediumPurpleFormat : ClassificationFormatDefinition{

                public DiffboldMediumPurpleFormat() { 
					this.ForegroundColor = Colors.MediumPurple; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MediumSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mediumseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMediumSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mediumseagreen")]
            [Name("text.bold.mediumseagreen")]
            internal sealed class DiffboldMediumSeaGreenFormat : ClassificationFormatDefinition{

                public DiffboldMediumSeaGreenFormat() { 
					this.ForegroundColor = Colors.MediumSeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MediumSlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mediumslateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMediumSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mediumslateblue")]
            [Name("text.bold.mediumslateblue")]
            internal sealed class DiffboldMediumSlateBlueFormat : ClassificationFormatDefinition{

                public DiffboldMediumSlateBlueFormat() { 
					this.ForegroundColor = Colors.MediumSlateBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MediumSpringGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mediumspringgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMediumSpringGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mediumspringgreen")]
            [Name("text.bold.mediumspringgreen")]
            internal sealed class DiffboldMediumSpringGreenFormat : ClassificationFormatDefinition{

                public DiffboldMediumSpringGreenFormat() { 
					this.ForegroundColor = Colors.MediumSpringGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MediumTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mediumturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMediumTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mediumturquoise")]
            [Name("text.bold.mediumturquoise")]
            internal sealed class DiffboldMediumTurquoiseFormat : ClassificationFormatDefinition{

                public DiffboldMediumTurquoiseFormat() { 
					this.ForegroundColor = Colors.MediumTurquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MediumVioletRed --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mediumvioletred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMediumVioletRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mediumvioletred")]
            [Name("text.bold.mediumvioletred")]
            internal sealed class DiffboldMediumVioletRedFormat : ClassificationFormatDefinition{

                public DiffboldMediumVioletRedFormat() { 
					this.ForegroundColor = Colors.MediumVioletRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MidnightBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.midnightblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMidnightBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.midnightblue")]
            [Name("text.bold.midnightblue")]
            internal sealed class DiffboldMidnightBlueFormat : ClassificationFormatDefinition{

                public DiffboldMidnightBlueFormat() { 
					this.ForegroundColor = Colors.MidnightBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MintCream --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mintcream")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMintCreamDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mintcream")]
            [Name("text.bold.mintcream")]
            internal sealed class DiffboldMintCreamFormat : ClassificationFormatDefinition{

                public DiffboldMintCreamFormat() { 
					this.ForegroundColor = Colors.MintCream; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- MistyRose --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.mistyrose")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMistyRoseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.mistyrose")]
            [Name("text.bold.mistyrose")]
            internal sealed class DiffboldMistyRoseFormat : ClassificationFormatDefinition{

                public DiffboldMistyRoseFormat() { 
					this.ForegroundColor = Colors.MistyRose; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Moccasin --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.moccasin")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldMoccasinDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.moccasin")]
            [Name("text.bold.moccasin")]
            internal sealed class DiffboldMoccasinFormat : ClassificationFormatDefinition{

                public DiffboldMoccasinFormat() { 
					this.ForegroundColor = Colors.Moccasin; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- NavajoWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.navajowhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldNavajoWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.navajowhite")]
            [Name("text.bold.navajowhite")]
            internal sealed class DiffboldNavajoWhiteFormat : ClassificationFormatDefinition{

                public DiffboldNavajoWhiteFormat() { 
					this.ForegroundColor = Colors.NavajoWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Navy --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.navy")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldNavyDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.navy")]
            [Name("text.bold.navy")]
            internal sealed class DiffboldNavyFormat : ClassificationFormatDefinition{

                public DiffboldNavyFormat() { 
					this.ForegroundColor = Colors.Navy; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- OldLace --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.oldlace")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldOldLaceDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.oldlace")]
            [Name("text.bold.oldlace")]
            internal sealed class DiffboldOldLaceFormat : ClassificationFormatDefinition{

                public DiffboldOldLaceFormat() { 
					this.ForegroundColor = Colors.OldLace; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Olive --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.olive")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldOliveDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.olive")]
            [Name("text.bold.olive")]
            internal sealed class DiffboldOliveFormat : ClassificationFormatDefinition{

                public DiffboldOliveFormat() { 
					this.ForegroundColor = Colors.Olive; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- OliveDrab --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.olivedrab")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldOliveDrabDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.olivedrab")]
            [Name("text.bold.olivedrab")]
            internal sealed class DiffboldOliveDrabFormat : ClassificationFormatDefinition{

                public DiffboldOliveDrabFormat() { 
					this.ForegroundColor = Colors.OliveDrab; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Orange --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.orange")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldOrangeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.orange")]
            [Name("text.bold.orange")]
            internal sealed class DiffboldOrangeFormat : ClassificationFormatDefinition{

                public DiffboldOrangeFormat() { 
					this.ForegroundColor = Colors.Orange; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- OrangeRed --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.orangered")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldOrangeRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.orangered")]
            [Name("text.bold.orangered")]
            internal sealed class DiffboldOrangeRedFormat : ClassificationFormatDefinition{

                public DiffboldOrangeRedFormat() { 
					this.ForegroundColor = Colors.OrangeRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Orchid --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.orchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.orchid")]
            [Name("text.bold.orchid")]
            internal sealed class DiffboldOrchidFormat : ClassificationFormatDefinition{

                public DiffboldOrchidFormat() { 
					this.ForegroundColor = Colors.Orchid; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- PaleGoldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.palegoldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPaleGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.palegoldenrod")]
            [Name("text.bold.palegoldenrod")]
            internal sealed class DiffboldPaleGoldenrodFormat : ClassificationFormatDefinition{

                public DiffboldPaleGoldenrodFormat() { 
					this.ForegroundColor = Colors.PaleGoldenrod; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- PaleGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.palegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPaleGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.palegreen")]
            [Name("text.bold.palegreen")]
            internal sealed class DiffboldPaleGreenFormat : ClassificationFormatDefinition{

                public DiffboldPaleGreenFormat() { 
					this.ForegroundColor = Colors.PaleGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- PaleTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.paleturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPaleTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.paleturquoise")]
            [Name("text.bold.paleturquoise")]
            internal sealed class DiffboldPaleTurquoiseFormat : ClassificationFormatDefinition{

                public DiffboldPaleTurquoiseFormat() { 
					this.ForegroundColor = Colors.PaleTurquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- PaleVioletRed --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.palevioletred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPaleVioletRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.palevioletred")]
            [Name("text.bold.palevioletred")]
            internal sealed class DiffboldPaleVioletRedFormat : ClassificationFormatDefinition{

                public DiffboldPaleVioletRedFormat() { 
					this.ForegroundColor = Colors.PaleVioletRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- PapayaWhip --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.papayawhip")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPapayaWhipDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.papayawhip")]
            [Name("text.bold.papayawhip")]
            internal sealed class DiffboldPapayaWhipFormat : ClassificationFormatDefinition{

                public DiffboldPapayaWhipFormat() { 
					this.ForegroundColor = Colors.PapayaWhip; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- PeachPuff --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.peachpuff")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPeachPuffDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.peachpuff")]
            [Name("text.bold.peachpuff")]
            internal sealed class DiffboldPeachPuffFormat : ClassificationFormatDefinition{

                public DiffboldPeachPuffFormat() { 
					this.ForegroundColor = Colors.PeachPuff; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Peru --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.peru")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPeruDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.peru")]
            [Name("text.bold.peru")]
            internal sealed class DiffboldPeruFormat : ClassificationFormatDefinition{

                public DiffboldPeruFormat() { 
					this.ForegroundColor = Colors.Peru; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Pink --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.pink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.pink")]
            [Name("text.bold.pink")]
            internal sealed class DiffboldPinkFormat : ClassificationFormatDefinition{

                public DiffboldPinkFormat() { 
					this.ForegroundColor = Colors.Pink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Plum --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.plum")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPlumDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.plum")]
            [Name("text.bold.plum")]
            internal sealed class DiffboldPlumFormat : ClassificationFormatDefinition{

                public DiffboldPlumFormat() { 
					this.ForegroundColor = Colors.Plum; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- PowderBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.powderblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPowderBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.powderblue")]
            [Name("text.bold.powderblue")]
            internal sealed class DiffboldPowderBlueFormat : ClassificationFormatDefinition{

                public DiffboldPowderBlueFormat() { 
					this.ForegroundColor = Colors.PowderBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Purple --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.purple")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldPurpleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.purple")]
            [Name("text.bold.purple")]
            internal sealed class DiffboldPurpleFormat : ClassificationFormatDefinition{

                public DiffboldPurpleFormat() { 
					this.ForegroundColor = Colors.Purple; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Red --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.red")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.red")]
            [Name("text.bold.red")]
            internal sealed class DiffboldRedFormat : ClassificationFormatDefinition{

                public DiffboldRedFormat() { 
					this.ForegroundColor = Colors.Red; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- RosyBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.rosybrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldRosyBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.rosybrown")]
            [Name("text.bold.rosybrown")]
            internal sealed class DiffboldRosyBrownFormat : ClassificationFormatDefinition{

                public DiffboldRosyBrownFormat() { 
					this.ForegroundColor = Colors.RosyBrown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- RoyalBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.royalblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldRoyalBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.royalblue")]
            [Name("text.bold.royalblue")]
            internal sealed class DiffboldRoyalBlueFormat : ClassificationFormatDefinition{

                public DiffboldRoyalBlueFormat() { 
					this.ForegroundColor = Colors.RoyalBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- SaddleBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.saddlebrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSaddleBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.saddlebrown")]
            [Name("text.bold.saddlebrown")]
            internal sealed class DiffboldSaddleBrownFormat : ClassificationFormatDefinition{

                public DiffboldSaddleBrownFormat() { 
					this.ForegroundColor = Colors.SaddleBrown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Salmon --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.salmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.salmon")]
            [Name("text.bold.salmon")]
            internal sealed class DiffboldSalmonFormat : ClassificationFormatDefinition{

                public DiffboldSalmonFormat() { 
					this.ForegroundColor = Colors.Salmon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- SandyBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.sandybrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSandyBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.sandybrown")]
            [Name("text.bold.sandybrown")]
            internal sealed class DiffboldSandyBrownFormat : ClassificationFormatDefinition{

                public DiffboldSandyBrownFormat() { 
					this.ForegroundColor = Colors.SandyBrown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- SeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.seagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.seagreen")]
            [Name("text.bold.seagreen")]
            internal sealed class DiffboldSeaGreenFormat : ClassificationFormatDefinition{

                public DiffboldSeaGreenFormat() { 
					this.ForegroundColor = Colors.SeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- SeaShell --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.seashell")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSeaShellDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.seashell")]
            [Name("text.bold.seashell")]
            internal sealed class DiffboldSeaShellFormat : ClassificationFormatDefinition{

                public DiffboldSeaShellFormat() { 
					this.ForegroundColor = Colors.SeaShell; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Sienna --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.sienna")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSiennaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.sienna")]
            [Name("text.bold.sienna")]
            internal sealed class DiffboldSiennaFormat : ClassificationFormatDefinition{

                public DiffboldSiennaFormat() { 
					this.ForegroundColor = Colors.Sienna; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Silver --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.silver")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSilverDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.silver")]
            [Name("text.bold.silver")]
            internal sealed class DiffboldSilverFormat : ClassificationFormatDefinition{

                public DiffboldSilverFormat() { 
					this.ForegroundColor = Colors.Silver; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- SkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.skyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.skyblue")]
            [Name("text.bold.skyblue")]
            internal sealed class DiffboldSkyBlueFormat : ClassificationFormatDefinition{

                public DiffboldSkyBlueFormat() { 
					this.ForegroundColor = Colors.SkyBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- SlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.slateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.slateblue")]
            [Name("text.bold.slateblue")]
            internal sealed class DiffboldSlateBlueFormat : ClassificationFormatDefinition{

                public DiffboldSlateBlueFormat() { 
					this.ForegroundColor = Colors.SlateBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- SlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.slategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.slategray")]
            [Name("text.bold.slategray")]
            internal sealed class DiffboldSlateGrayFormat : ClassificationFormatDefinition{

                public DiffboldSlateGrayFormat() { 
					this.ForegroundColor = Colors.SlateGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Snow --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.snow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSnowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.snow")]
            [Name("text.bold.snow")]
            internal sealed class DiffboldSnowFormat : ClassificationFormatDefinition{

                public DiffboldSnowFormat() { 
					this.ForegroundColor = Colors.Snow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- SpringGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.springgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSpringGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.springgreen")]
            [Name("text.bold.springgreen")]
            internal sealed class DiffboldSpringGreenFormat : ClassificationFormatDefinition{

                public DiffboldSpringGreenFormat() { 
					this.ForegroundColor = Colors.SpringGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- SteelBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.steelblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldSteelBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.steelblue")]
            [Name("text.bold.steelblue")]
            internal sealed class DiffboldSteelBlueFormat : ClassificationFormatDefinition{

                public DiffboldSteelBlueFormat() { 
					this.ForegroundColor = Colors.SteelBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Tan --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.tan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldTanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.tan")]
            [Name("text.bold.tan")]
            internal sealed class DiffboldTanFormat : ClassificationFormatDefinition{

                public DiffboldTanFormat() { 
					this.ForegroundColor = Colors.Tan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Teal --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.teal")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldTealDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.teal")]
            [Name("text.bold.teal")]
            internal sealed class DiffboldTealFormat : ClassificationFormatDefinition{

                public DiffboldTealFormat() { 
					this.ForegroundColor = Colors.Teal; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Thistle --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.thistle")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldThistleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.thistle")]
            [Name("text.bold.thistle")]
            internal sealed class DiffboldThistleFormat : ClassificationFormatDefinition{

                public DiffboldThistleFormat() { 
					this.ForegroundColor = Colors.Thistle; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Tomato --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.tomato")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldTomatoDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.tomato")]
            [Name("text.bold.tomato")]
            internal sealed class DiffboldTomatoFormat : ClassificationFormatDefinition{

                public DiffboldTomatoFormat() { 
					this.ForegroundColor = Colors.Tomato; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Transparent --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.transparent")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldTransparentDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.transparent")]
            [Name("text.bold.transparent")]
            internal sealed class DiffboldTransparentFormat : ClassificationFormatDefinition{

                public DiffboldTransparentFormat() { 
					this.ForegroundColor = Colors.Transparent; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Turquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.turquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.turquoise")]
            [Name("text.bold.turquoise")]
            internal sealed class DiffboldTurquoiseFormat : ClassificationFormatDefinition{

                public DiffboldTurquoiseFormat() { 
					this.ForegroundColor = Colors.Turquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Violet --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.violet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.violet")]
            [Name("text.bold.violet")]
            internal sealed class DiffboldVioletFormat : ClassificationFormatDefinition{

                public DiffboldVioletFormat() { 
					this.ForegroundColor = Colors.Violet; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Wheat --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.wheat")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldWheatDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.wheat")]
            [Name("text.bold.wheat")]
            internal sealed class DiffboldWheatFormat : ClassificationFormatDefinition{

                public DiffboldWheatFormat() { 
					this.ForegroundColor = Colors.Wheat; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- White --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.white")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.white")]
            [Name("text.bold.white")]
            internal sealed class DiffboldWhiteFormat : ClassificationFormatDefinition{

                public DiffboldWhiteFormat() { 
					this.ForegroundColor = Colors.White; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- WhiteSmoke --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.whitesmoke")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldWhiteSmokeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.whitesmoke")]
            [Name("text.bold.whitesmoke")]
            internal sealed class DiffboldWhiteSmokeFormat : ClassificationFormatDefinition{

                public DiffboldWhiteSmokeFormat() { 
					this.ForegroundColor = Colors.WhiteSmoke; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- Yellow --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.yellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.yellow")]
            [Name("text.bold.yellow")]
            internal sealed class DiffboldYellowFormat : ClassificationFormatDefinition{

                public DiffboldYellowFormat() { 
					this.ForegroundColor = Colors.Yellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
                    
            /* -- YellowGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bold.yellowgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffboldYellowGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bold.yellowgreen")]
            [Name("text.bold.yellowgreen")]
            internal sealed class DiffboldYellowGreenFormat : ClassificationFormatDefinition{

                public DiffboldYellowGreenFormat() { 
					this.ForegroundColor = Colors.YellowGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
				}
            }
        


    }
}