
using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
    
namespace FTVSToolKit { //AA 

    internal static class AllColorsBoldItalicDefinition { // DiffClassificationDefinitions
	
                    
            /* -- AliceBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.aliceblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicAliceBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.aliceblue")]
            [Name("text.bolditalic.aliceblue")]
            internal sealed class DiffbolditalicAliceBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicAliceBlueFormat() { 
					this.ForegroundColor = Colors.AliceBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- AntiqueWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.antiquewhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicAntiqueWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.antiquewhite")]
            [Name("text.bolditalic.antiquewhite")]
            internal sealed class DiffbolditalicAntiqueWhiteFormat : ClassificationFormatDefinition{

                public DiffbolditalicAntiqueWhiteFormat() { 
					this.ForegroundColor = Colors.AntiqueWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Aqua --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.aqua")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicAquaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.aqua")]
            [Name("text.bolditalic.aqua")]
            internal sealed class DiffbolditalicAquaFormat : ClassificationFormatDefinition{

                public DiffbolditalicAquaFormat() { 
					this.ForegroundColor = Colors.Aqua; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Aquamarine --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.aquamarine")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicAquamarineDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.aquamarine")]
            [Name("text.bolditalic.aquamarine")]
            internal sealed class DiffbolditalicAquamarineFormat : ClassificationFormatDefinition{

                public DiffbolditalicAquamarineFormat() { 
					this.ForegroundColor = Colors.Aquamarine; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Azure --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.azure")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicAzureDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.azure")]
            [Name("text.bolditalic.azure")]
            internal sealed class DiffbolditalicAzureFormat : ClassificationFormatDefinition{

                public DiffbolditalicAzureFormat() { 
					this.ForegroundColor = Colors.Azure; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Beige --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.beige")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicBeigeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.beige")]
            [Name("text.bolditalic.beige")]
            internal sealed class DiffbolditalicBeigeFormat : ClassificationFormatDefinition{

                public DiffbolditalicBeigeFormat() { 
					this.ForegroundColor = Colors.Beige; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Bisque --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.bisque")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicBisqueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.bisque")]
            [Name("text.bolditalic.bisque")]
            internal sealed class DiffbolditalicBisqueFormat : ClassificationFormatDefinition{

                public DiffbolditalicBisqueFormat() { 
					this.ForegroundColor = Colors.Bisque; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Black --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.black")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicBlackDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.black")]
            [Name("text.bolditalic.black")]
            internal sealed class DiffbolditalicBlackFormat : ClassificationFormatDefinition{

                public DiffbolditalicBlackFormat() { 
					this.ForegroundColor = Colors.Black; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- BlanchedAlmond --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.blanchedalmond")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicBlanchedAlmondDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.blanchedalmond")]
            [Name("text.bolditalic.blanchedalmond")]
            internal sealed class DiffbolditalicBlanchedAlmondFormat : ClassificationFormatDefinition{

                public DiffbolditalicBlanchedAlmondFormat() { 
					this.ForegroundColor = Colors.BlanchedAlmond; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Blue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.blue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.blue")]
            [Name("text.bolditalic.blue")]
            internal sealed class DiffbolditalicBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicBlueFormat() { 
					this.ForegroundColor = Colors.Blue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- BlueViolet --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.blueviolet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicBlueVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.blueviolet")]
            [Name("text.bolditalic.blueviolet")]
            internal sealed class DiffbolditalicBlueVioletFormat : ClassificationFormatDefinition{

                public DiffbolditalicBlueVioletFormat() { 
					this.ForegroundColor = Colors.BlueViolet; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Brown --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.brown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.brown")]
            [Name("text.bolditalic.brown")]
            internal sealed class DiffbolditalicBrownFormat : ClassificationFormatDefinition{

                public DiffbolditalicBrownFormat() { 
					this.ForegroundColor = Colors.Brown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- BurlyWood --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.burlywood")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicBurlyWoodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.burlywood")]
            [Name("text.bolditalic.burlywood")]
            internal sealed class DiffbolditalicBurlyWoodFormat : ClassificationFormatDefinition{

                public DiffbolditalicBurlyWoodFormat() { 
					this.ForegroundColor = Colors.BurlyWood; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- CadetBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.cadetblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicCadetBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.cadetblue")]
            [Name("text.bolditalic.cadetblue")]
            internal sealed class DiffbolditalicCadetBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicCadetBlueFormat() { 
					this.ForegroundColor = Colors.CadetBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Chartreuse --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.chartreuse")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicChartreuseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.chartreuse")]
            [Name("text.bolditalic.chartreuse")]
            internal sealed class DiffbolditalicChartreuseFormat : ClassificationFormatDefinition{

                public DiffbolditalicChartreuseFormat() { 
					this.ForegroundColor = Colors.Chartreuse; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Chocolate --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.chocolate")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicChocolateDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.chocolate")]
            [Name("text.bolditalic.chocolate")]
            internal sealed class DiffbolditalicChocolateFormat : ClassificationFormatDefinition{

                public DiffbolditalicChocolateFormat() { 
					this.ForegroundColor = Colors.Chocolate; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Coral --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.coral")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicCoralDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.coral")]
            [Name("text.bolditalic.coral")]
            internal sealed class DiffbolditalicCoralFormat : ClassificationFormatDefinition{

                public DiffbolditalicCoralFormat() { 
					this.ForegroundColor = Colors.Coral; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- CornflowerBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.cornflowerblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicCornflowerBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.cornflowerblue")]
            [Name("text.bolditalic.cornflowerblue")]
            internal sealed class DiffbolditalicCornflowerBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicCornflowerBlueFormat() { 
					this.ForegroundColor = Colors.CornflowerBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Cornsilk --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.cornsilk")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicCornsilkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.cornsilk")]
            [Name("text.bolditalic.cornsilk")]
            internal sealed class DiffbolditalicCornsilkFormat : ClassificationFormatDefinition{

                public DiffbolditalicCornsilkFormat() { 
					this.ForegroundColor = Colors.Cornsilk; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Crimson --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.crimson")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicCrimsonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.crimson")]
            [Name("text.bolditalic.crimson")]
            internal sealed class DiffbolditalicCrimsonFormat : ClassificationFormatDefinition{

                public DiffbolditalicCrimsonFormat() { 
					this.ForegroundColor = Colors.Crimson; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Cyan --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.cyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.cyan")]
            [Name("text.bolditalic.cyan")]
            internal sealed class DiffbolditalicCyanFormat : ClassificationFormatDefinition{

                public DiffbolditalicCyanFormat() { 
					this.ForegroundColor = Colors.Cyan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkblue")]
            [Name("text.bolditalic.darkblue")]
            internal sealed class DiffbolditalicDarkBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkBlueFormat() { 
					this.ForegroundColor = Colors.DarkBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkCyan --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkcyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkcyan")]
            [Name("text.bolditalic.darkcyan")]
            internal sealed class DiffbolditalicDarkCyanFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkCyanFormat() { 
					this.ForegroundColor = Colors.DarkCyan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkGoldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkgoldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkgoldenrod")]
            [Name("text.bolditalic.darkgoldenrod")]
            internal sealed class DiffbolditalicDarkGoldenrodFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkGoldenrodFormat() { 
					this.ForegroundColor = Colors.DarkGoldenrod; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkgray")]
            [Name("text.bolditalic.darkgray")]
            internal sealed class DiffbolditalicDarkGrayFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkGrayFormat() { 
					this.ForegroundColor = Colors.DarkGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkgreen")]
            [Name("text.bolditalic.darkgreen")]
            internal sealed class DiffbolditalicDarkGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkGreenFormat() { 
					this.ForegroundColor = Colors.DarkGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkKhaki --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkkhaki")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkKhakiDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkkhaki")]
            [Name("text.bolditalic.darkkhaki")]
            internal sealed class DiffbolditalicDarkKhakiFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkKhakiFormat() { 
					this.ForegroundColor = Colors.DarkKhaki; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkMagenta --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkmagenta")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkMagentaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkmagenta")]
            [Name("text.bolditalic.darkmagenta")]
            internal sealed class DiffbolditalicDarkMagentaFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkMagentaFormat() { 
					this.ForegroundColor = Colors.DarkMagenta; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkOliveGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkolivegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkOliveGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkolivegreen")]
            [Name("text.bolditalic.darkolivegreen")]
            internal sealed class DiffbolditalicDarkOliveGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkOliveGreenFormat() { 
					this.ForegroundColor = Colors.DarkOliveGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkOrange --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkorange")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkOrangeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkorange")]
            [Name("text.bolditalic.darkorange")]
            internal sealed class DiffbolditalicDarkOrangeFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkOrangeFormat() { 
					this.ForegroundColor = Colors.DarkOrange; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkOrchid --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkorchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkorchid")]
            [Name("text.bolditalic.darkorchid")]
            internal sealed class DiffbolditalicDarkOrchidFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkOrchidFormat() { 
					this.ForegroundColor = Colors.DarkOrchid; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkRed --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkred")]
            [Name("text.bolditalic.darkred")]
            internal sealed class DiffbolditalicDarkRedFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkRedFormat() { 
					this.ForegroundColor = Colors.DarkRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkSalmon --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darksalmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darksalmon")]
            [Name("text.bolditalic.darksalmon")]
            internal sealed class DiffbolditalicDarkSalmonFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkSalmonFormat() { 
					this.ForegroundColor = Colors.DarkSalmon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkseagreen")]
            [Name("text.bolditalic.darkseagreen")]
            internal sealed class DiffbolditalicDarkSeaGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkSeaGreenFormat() { 
					this.ForegroundColor = Colors.DarkSeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkSlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkslateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkslateblue")]
            [Name("text.bolditalic.darkslateblue")]
            internal sealed class DiffbolditalicDarkSlateBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkSlateBlueFormat() { 
					this.ForegroundColor = Colors.DarkSlateBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkSlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkslategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkslategray")]
            [Name("text.bolditalic.darkslategray")]
            internal sealed class DiffbolditalicDarkSlateGrayFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkSlateGrayFormat() { 
					this.ForegroundColor = Colors.DarkSlateGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkturquoise")]
            [Name("text.bolditalic.darkturquoise")]
            internal sealed class DiffbolditalicDarkTurquoiseFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkTurquoiseFormat() { 
					this.ForegroundColor = Colors.DarkTurquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DarkViolet --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.darkviolet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDarkVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.darkviolet")]
            [Name("text.bolditalic.darkviolet")]
            internal sealed class DiffbolditalicDarkVioletFormat : ClassificationFormatDefinition{

                public DiffbolditalicDarkVioletFormat() { 
					this.ForegroundColor = Colors.DarkViolet; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DeepPink --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.deeppink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDeepPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.deeppink")]
            [Name("text.bolditalic.deeppink")]
            internal sealed class DiffbolditalicDeepPinkFormat : ClassificationFormatDefinition{

                public DiffbolditalicDeepPinkFormat() { 
					this.ForegroundColor = Colors.DeepPink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DeepSkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.deepskyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDeepSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.deepskyblue")]
            [Name("text.bolditalic.deepskyblue")]
            internal sealed class DiffbolditalicDeepSkyBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicDeepSkyBlueFormat() { 
					this.ForegroundColor = Colors.DeepSkyBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DimGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.dimgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDimGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.dimgray")]
            [Name("text.bolditalic.dimgray")]
            internal sealed class DiffbolditalicDimGrayFormat : ClassificationFormatDefinition{

                public DiffbolditalicDimGrayFormat() { 
					this.ForegroundColor = Colors.DimGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- DodgerBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.dodgerblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicDodgerBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.dodgerblue")]
            [Name("text.bolditalic.dodgerblue")]
            internal sealed class DiffbolditalicDodgerBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicDodgerBlueFormat() { 
					this.ForegroundColor = Colors.DodgerBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Firebrick --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.firebrick")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicFirebrickDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.firebrick")]
            [Name("text.bolditalic.firebrick")]
            internal sealed class DiffbolditalicFirebrickFormat : ClassificationFormatDefinition{

                public DiffbolditalicFirebrickFormat() { 
					this.ForegroundColor = Colors.Firebrick; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- FloralWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.floralwhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicFloralWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.floralwhite")]
            [Name("text.bolditalic.floralwhite")]
            internal sealed class DiffbolditalicFloralWhiteFormat : ClassificationFormatDefinition{

                public DiffbolditalicFloralWhiteFormat() { 
					this.ForegroundColor = Colors.FloralWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- ForestGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.forestgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicForestGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.forestgreen")]
            [Name("text.bolditalic.forestgreen")]
            internal sealed class DiffbolditalicForestGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicForestGreenFormat() { 
					this.ForegroundColor = Colors.ForestGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Fuchsia --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.fuchsia")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicFuchsiaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.fuchsia")]
            [Name("text.bolditalic.fuchsia")]
            internal sealed class DiffbolditalicFuchsiaFormat : ClassificationFormatDefinition{

                public DiffbolditalicFuchsiaFormat() { 
					this.ForegroundColor = Colors.Fuchsia; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Gainsboro --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.gainsboro")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicGainsboroDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.gainsboro")]
            [Name("text.bolditalic.gainsboro")]
            internal sealed class DiffbolditalicGainsboroFormat : ClassificationFormatDefinition{

                public DiffbolditalicGainsboroFormat() { 
					this.ForegroundColor = Colors.Gainsboro; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- GhostWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.ghostwhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicGhostWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.ghostwhite")]
            [Name("text.bolditalic.ghostwhite")]
            internal sealed class DiffbolditalicGhostWhiteFormat : ClassificationFormatDefinition{

                public DiffbolditalicGhostWhiteFormat() { 
					this.ForegroundColor = Colors.GhostWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Gold --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.gold")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicGoldDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.gold")]
            [Name("text.bolditalic.gold")]
            internal sealed class DiffbolditalicGoldFormat : ClassificationFormatDefinition{

                public DiffbolditalicGoldFormat() { 
					this.ForegroundColor = Colors.Gold; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Goldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.goldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.goldenrod")]
            [Name("text.bolditalic.goldenrod")]
            internal sealed class DiffbolditalicGoldenrodFormat : ClassificationFormatDefinition{

                public DiffbolditalicGoldenrodFormat() { 
					this.ForegroundColor = Colors.Goldenrod; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Gray --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.gray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.gray")]
            [Name("text.bolditalic.gray")]
            internal sealed class DiffbolditalicGrayFormat : ClassificationFormatDefinition{

                public DiffbolditalicGrayFormat() { 
					this.ForegroundColor = Colors.Gray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Green --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.green")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.green")]
            [Name("text.bolditalic.green")]
            internal sealed class DiffbolditalicGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicGreenFormat() { 
					this.ForegroundColor = Colors.Green; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- GreenYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.greenyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicGreenYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.greenyellow")]
            [Name("text.bolditalic.greenyellow")]
            internal sealed class DiffbolditalicGreenYellowFormat : ClassificationFormatDefinition{

                public DiffbolditalicGreenYellowFormat() { 
					this.ForegroundColor = Colors.GreenYellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Honeydew --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.honeydew")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicHoneydewDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.honeydew")]
            [Name("text.bolditalic.honeydew")]
            internal sealed class DiffbolditalicHoneydewFormat : ClassificationFormatDefinition{

                public DiffbolditalicHoneydewFormat() { 
					this.ForegroundColor = Colors.Honeydew; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- HotPink --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.hotpink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicHotPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.hotpink")]
            [Name("text.bolditalic.hotpink")]
            internal sealed class DiffbolditalicHotPinkFormat : ClassificationFormatDefinition{

                public DiffbolditalicHotPinkFormat() { 
					this.ForegroundColor = Colors.HotPink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- IndianRed --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.indianred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicIndianRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.indianred")]
            [Name("text.bolditalic.indianred")]
            internal sealed class DiffbolditalicIndianRedFormat : ClassificationFormatDefinition{

                public DiffbolditalicIndianRedFormat() { 
					this.ForegroundColor = Colors.IndianRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Indigo --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.indigo")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicIndigoDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.indigo")]
            [Name("text.bolditalic.indigo")]
            internal sealed class DiffbolditalicIndigoFormat : ClassificationFormatDefinition{

                public DiffbolditalicIndigoFormat() { 
					this.ForegroundColor = Colors.Indigo; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Ivory --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.ivory")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicIvoryDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.ivory")]
            [Name("text.bolditalic.ivory")]
            internal sealed class DiffbolditalicIvoryFormat : ClassificationFormatDefinition{

                public DiffbolditalicIvoryFormat() { 
					this.ForegroundColor = Colors.Ivory; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Khaki --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.khaki")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicKhakiDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.khaki")]
            [Name("text.bolditalic.khaki")]
            internal sealed class DiffbolditalicKhakiFormat : ClassificationFormatDefinition{

                public DiffbolditalicKhakiFormat() { 
					this.ForegroundColor = Colors.Khaki; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Lavender --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lavender")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLavenderDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lavender")]
            [Name("text.bolditalic.lavender")]
            internal sealed class DiffbolditalicLavenderFormat : ClassificationFormatDefinition{

                public DiffbolditalicLavenderFormat() { 
					this.ForegroundColor = Colors.Lavender; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LavenderBlush --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lavenderblush")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLavenderBlushDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lavenderblush")]
            [Name("text.bolditalic.lavenderblush")]
            internal sealed class DiffbolditalicLavenderBlushFormat : ClassificationFormatDefinition{

                public DiffbolditalicLavenderBlushFormat() { 
					this.ForegroundColor = Colors.LavenderBlush; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LawnGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lawngreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLawnGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lawngreen")]
            [Name("text.bolditalic.lawngreen")]
            internal sealed class DiffbolditalicLawnGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicLawnGreenFormat() { 
					this.ForegroundColor = Colors.LawnGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LemonChiffon --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lemonchiffon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLemonChiffonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lemonchiffon")]
            [Name("text.bolditalic.lemonchiffon")]
            internal sealed class DiffbolditalicLemonChiffonFormat : ClassificationFormatDefinition{

                public DiffbolditalicLemonChiffonFormat() { 
					this.ForegroundColor = Colors.LemonChiffon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightblue")]
            [Name("text.bolditalic.lightblue")]
            internal sealed class DiffbolditalicLightBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightBlueFormat() { 
					this.ForegroundColor = Colors.LightBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightCoral --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightcoral")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightCoralDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightcoral")]
            [Name("text.bolditalic.lightcoral")]
            internal sealed class DiffbolditalicLightCoralFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightCoralFormat() { 
					this.ForegroundColor = Colors.LightCoral; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightCyan --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightcyan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightCyanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightcyan")]
            [Name("text.bolditalic.lightcyan")]
            internal sealed class DiffbolditalicLightCyanFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightCyanFormat() { 
					this.ForegroundColor = Colors.LightCyan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightGoldenrodYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightgoldenrodyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightGoldenrodYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightgoldenrodyellow")]
            [Name("text.bolditalic.lightgoldenrodyellow")]
            internal sealed class DiffbolditalicLightGoldenrodYellowFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightGoldenrodYellowFormat() { 
					this.ForegroundColor = Colors.LightGoldenrodYellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightgray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightgray")]
            [Name("text.bolditalic.lightgray")]
            internal sealed class DiffbolditalicLightGrayFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightGrayFormat() { 
					this.ForegroundColor = Colors.LightGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightgreen")]
            [Name("text.bolditalic.lightgreen")]
            internal sealed class DiffbolditalicLightGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightGreenFormat() { 
					this.ForegroundColor = Colors.LightGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightPink --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightpink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightpink")]
            [Name("text.bolditalic.lightpink")]
            internal sealed class DiffbolditalicLightPinkFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightPinkFormat() { 
					this.ForegroundColor = Colors.LightPink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightSalmon --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightsalmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightsalmon")]
            [Name("text.bolditalic.lightsalmon")]
            internal sealed class DiffbolditalicLightSalmonFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightSalmonFormat() { 
					this.ForegroundColor = Colors.LightSalmon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightseagreen")]
            [Name("text.bolditalic.lightseagreen")]
            internal sealed class DiffbolditalicLightSeaGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightSeaGreenFormat() { 
					this.ForegroundColor = Colors.LightSeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightSkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightskyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightskyblue")]
            [Name("text.bolditalic.lightskyblue")]
            internal sealed class DiffbolditalicLightSkyBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightSkyBlueFormat() { 
					this.ForegroundColor = Colors.LightSkyBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightSlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightslategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightslategray")]
            [Name("text.bolditalic.lightslategray")]
            internal sealed class DiffbolditalicLightSlateGrayFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightSlateGrayFormat() { 
					this.ForegroundColor = Colors.LightSlateGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightSteelBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightsteelblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightSteelBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightsteelblue")]
            [Name("text.bolditalic.lightsteelblue")]
            internal sealed class DiffbolditalicLightSteelBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightSteelBlueFormat() { 
					this.ForegroundColor = Colors.LightSteelBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LightYellow --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lightyellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLightYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lightyellow")]
            [Name("text.bolditalic.lightyellow")]
            internal sealed class DiffbolditalicLightYellowFormat : ClassificationFormatDefinition{

                public DiffbolditalicLightYellowFormat() { 
					this.ForegroundColor = Colors.LightYellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Lime --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.lime")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLimeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.lime")]
            [Name("text.bolditalic.lime")]
            internal sealed class DiffbolditalicLimeFormat : ClassificationFormatDefinition{

                public DiffbolditalicLimeFormat() { 
					this.ForegroundColor = Colors.Lime; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- LimeGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.limegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLimeGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.limegreen")]
            [Name("text.bolditalic.limegreen")]
            internal sealed class DiffbolditalicLimeGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicLimeGreenFormat() { 
					this.ForegroundColor = Colors.LimeGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Linen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.linen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicLinenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.linen")]
            [Name("text.bolditalic.linen")]
            internal sealed class DiffbolditalicLinenFormat : ClassificationFormatDefinition{

                public DiffbolditalicLinenFormat() { 
					this.ForegroundColor = Colors.Linen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Magenta --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.magenta")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMagentaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.magenta")]
            [Name("text.bolditalic.magenta")]
            internal sealed class DiffbolditalicMagentaFormat : ClassificationFormatDefinition{

                public DiffbolditalicMagentaFormat() { 
					this.ForegroundColor = Colors.Magenta; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Maroon --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.maroon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMaroonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.maroon")]
            [Name("text.bolditalic.maroon")]
            internal sealed class DiffbolditalicMaroonFormat : ClassificationFormatDefinition{

                public DiffbolditalicMaroonFormat() { 
					this.ForegroundColor = Colors.Maroon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumAquamarine --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mediumaquamarine")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMediumAquamarineDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mediumaquamarine")]
            [Name("text.bolditalic.mediumaquamarine")]
            internal sealed class DiffbolditalicMediumAquamarineFormat : ClassificationFormatDefinition{

                public DiffbolditalicMediumAquamarineFormat() { 
					this.ForegroundColor = Colors.MediumAquamarine; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mediumblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMediumBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mediumblue")]
            [Name("text.bolditalic.mediumblue")]
            internal sealed class DiffbolditalicMediumBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicMediumBlueFormat() { 
					this.ForegroundColor = Colors.MediumBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumOrchid --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mediumorchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMediumOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mediumorchid")]
            [Name("text.bolditalic.mediumorchid")]
            internal sealed class DiffbolditalicMediumOrchidFormat : ClassificationFormatDefinition{

                public DiffbolditalicMediumOrchidFormat() { 
					this.ForegroundColor = Colors.MediumOrchid; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumPurple --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mediumpurple")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMediumPurpleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mediumpurple")]
            [Name("text.bolditalic.mediumpurple")]
            internal sealed class DiffbolditalicMediumPurpleFormat : ClassificationFormatDefinition{

                public DiffbolditalicMediumPurpleFormat() { 
					this.ForegroundColor = Colors.MediumPurple; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumSeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mediumseagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMediumSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mediumseagreen")]
            [Name("text.bolditalic.mediumseagreen")]
            internal sealed class DiffbolditalicMediumSeaGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicMediumSeaGreenFormat() { 
					this.ForegroundColor = Colors.MediumSeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumSlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mediumslateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMediumSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mediumslateblue")]
            [Name("text.bolditalic.mediumslateblue")]
            internal sealed class DiffbolditalicMediumSlateBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicMediumSlateBlueFormat() { 
					this.ForegroundColor = Colors.MediumSlateBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumSpringGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mediumspringgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMediumSpringGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mediumspringgreen")]
            [Name("text.bolditalic.mediumspringgreen")]
            internal sealed class DiffbolditalicMediumSpringGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicMediumSpringGreenFormat() { 
					this.ForegroundColor = Colors.MediumSpringGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mediumturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMediumTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mediumturquoise")]
            [Name("text.bolditalic.mediumturquoise")]
            internal sealed class DiffbolditalicMediumTurquoiseFormat : ClassificationFormatDefinition{

                public DiffbolditalicMediumTurquoiseFormat() { 
					this.ForegroundColor = Colors.MediumTurquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MediumVioletRed --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mediumvioletred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMediumVioletRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mediumvioletred")]
            [Name("text.bolditalic.mediumvioletred")]
            internal sealed class DiffbolditalicMediumVioletRedFormat : ClassificationFormatDefinition{

                public DiffbolditalicMediumVioletRedFormat() { 
					this.ForegroundColor = Colors.MediumVioletRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MidnightBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.midnightblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMidnightBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.midnightblue")]
            [Name("text.bolditalic.midnightblue")]
            internal sealed class DiffbolditalicMidnightBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicMidnightBlueFormat() { 
					this.ForegroundColor = Colors.MidnightBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MintCream --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mintcream")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMintCreamDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mintcream")]
            [Name("text.bolditalic.mintcream")]
            internal sealed class DiffbolditalicMintCreamFormat : ClassificationFormatDefinition{

                public DiffbolditalicMintCreamFormat() { 
					this.ForegroundColor = Colors.MintCream; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- MistyRose --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.mistyrose")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMistyRoseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.mistyrose")]
            [Name("text.bolditalic.mistyrose")]
            internal sealed class DiffbolditalicMistyRoseFormat : ClassificationFormatDefinition{

                public DiffbolditalicMistyRoseFormat() { 
					this.ForegroundColor = Colors.MistyRose; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Moccasin --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.moccasin")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicMoccasinDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.moccasin")]
            [Name("text.bolditalic.moccasin")]
            internal sealed class DiffbolditalicMoccasinFormat : ClassificationFormatDefinition{

                public DiffbolditalicMoccasinFormat() { 
					this.ForegroundColor = Colors.Moccasin; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- NavajoWhite --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.navajowhite")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicNavajoWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.navajowhite")]
            [Name("text.bolditalic.navajowhite")]
            internal sealed class DiffbolditalicNavajoWhiteFormat : ClassificationFormatDefinition{

                public DiffbolditalicNavajoWhiteFormat() { 
					this.ForegroundColor = Colors.NavajoWhite; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Navy --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.navy")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicNavyDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.navy")]
            [Name("text.bolditalic.navy")]
            internal sealed class DiffbolditalicNavyFormat : ClassificationFormatDefinition{

                public DiffbolditalicNavyFormat() { 
					this.ForegroundColor = Colors.Navy; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- OldLace --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.oldlace")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicOldLaceDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.oldlace")]
            [Name("text.bolditalic.oldlace")]
            internal sealed class DiffbolditalicOldLaceFormat : ClassificationFormatDefinition{

                public DiffbolditalicOldLaceFormat() { 
					this.ForegroundColor = Colors.OldLace; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Olive --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.olive")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicOliveDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.olive")]
            [Name("text.bolditalic.olive")]
            internal sealed class DiffbolditalicOliveFormat : ClassificationFormatDefinition{

                public DiffbolditalicOliveFormat() { 
					this.ForegroundColor = Colors.Olive; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- OliveDrab --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.olivedrab")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicOliveDrabDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.olivedrab")]
            [Name("text.bolditalic.olivedrab")]
            internal sealed class DiffbolditalicOliveDrabFormat : ClassificationFormatDefinition{

                public DiffbolditalicOliveDrabFormat() { 
					this.ForegroundColor = Colors.OliveDrab; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Orange --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.orange")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicOrangeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.orange")]
            [Name("text.bolditalic.orange")]
            internal sealed class DiffbolditalicOrangeFormat : ClassificationFormatDefinition{

                public DiffbolditalicOrangeFormat() { 
					this.ForegroundColor = Colors.Orange; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- OrangeRed --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.orangered")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicOrangeRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.orangered")]
            [Name("text.bolditalic.orangered")]
            internal sealed class DiffbolditalicOrangeRedFormat : ClassificationFormatDefinition{

                public DiffbolditalicOrangeRedFormat() { 
					this.ForegroundColor = Colors.OrangeRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Orchid --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.orchid")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicOrchidDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.orchid")]
            [Name("text.bolditalic.orchid")]
            internal sealed class DiffbolditalicOrchidFormat : ClassificationFormatDefinition{

                public DiffbolditalicOrchidFormat() { 
					this.ForegroundColor = Colors.Orchid; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PaleGoldenrod --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.palegoldenrod")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPaleGoldenrodDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.palegoldenrod")]
            [Name("text.bolditalic.palegoldenrod")]
            internal sealed class DiffbolditalicPaleGoldenrodFormat : ClassificationFormatDefinition{

                public DiffbolditalicPaleGoldenrodFormat() { 
					this.ForegroundColor = Colors.PaleGoldenrod; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PaleGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.palegreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPaleGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.palegreen")]
            [Name("text.bolditalic.palegreen")]
            internal sealed class DiffbolditalicPaleGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicPaleGreenFormat() { 
					this.ForegroundColor = Colors.PaleGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PaleTurquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.paleturquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPaleTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.paleturquoise")]
            [Name("text.bolditalic.paleturquoise")]
            internal sealed class DiffbolditalicPaleTurquoiseFormat : ClassificationFormatDefinition{

                public DiffbolditalicPaleTurquoiseFormat() { 
					this.ForegroundColor = Colors.PaleTurquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PaleVioletRed --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.palevioletred")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPaleVioletRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.palevioletred")]
            [Name("text.bolditalic.palevioletred")]
            internal sealed class DiffbolditalicPaleVioletRedFormat : ClassificationFormatDefinition{

                public DiffbolditalicPaleVioletRedFormat() { 
					this.ForegroundColor = Colors.PaleVioletRed; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PapayaWhip --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.papayawhip")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPapayaWhipDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.papayawhip")]
            [Name("text.bolditalic.papayawhip")]
            internal sealed class DiffbolditalicPapayaWhipFormat : ClassificationFormatDefinition{

                public DiffbolditalicPapayaWhipFormat() { 
					this.ForegroundColor = Colors.PapayaWhip; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PeachPuff --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.peachpuff")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPeachPuffDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.peachpuff")]
            [Name("text.bolditalic.peachpuff")]
            internal sealed class DiffbolditalicPeachPuffFormat : ClassificationFormatDefinition{

                public DiffbolditalicPeachPuffFormat() { 
					this.ForegroundColor = Colors.PeachPuff; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Peru --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.peru")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPeruDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.peru")]
            [Name("text.bolditalic.peru")]
            internal sealed class DiffbolditalicPeruFormat : ClassificationFormatDefinition{

                public DiffbolditalicPeruFormat() { 
					this.ForegroundColor = Colors.Peru; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Pink --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.pink")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPinkDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.pink")]
            [Name("text.bolditalic.pink")]
            internal sealed class DiffbolditalicPinkFormat : ClassificationFormatDefinition{

                public DiffbolditalicPinkFormat() { 
					this.ForegroundColor = Colors.Pink; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Plum --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.plum")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPlumDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.plum")]
            [Name("text.bolditalic.plum")]
            internal sealed class DiffbolditalicPlumFormat : ClassificationFormatDefinition{

                public DiffbolditalicPlumFormat() { 
					this.ForegroundColor = Colors.Plum; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- PowderBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.powderblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPowderBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.powderblue")]
            [Name("text.bolditalic.powderblue")]
            internal sealed class DiffbolditalicPowderBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicPowderBlueFormat() { 
					this.ForegroundColor = Colors.PowderBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Purple --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.purple")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicPurpleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.purple")]
            [Name("text.bolditalic.purple")]
            internal sealed class DiffbolditalicPurpleFormat : ClassificationFormatDefinition{

                public DiffbolditalicPurpleFormat() { 
					this.ForegroundColor = Colors.Purple; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Red --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.red")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicRedDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.red")]
            [Name("text.bolditalic.red")]
            internal sealed class DiffbolditalicRedFormat : ClassificationFormatDefinition{

                public DiffbolditalicRedFormat() { 
					this.ForegroundColor = Colors.Red; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- RosyBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.rosybrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicRosyBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.rosybrown")]
            [Name("text.bolditalic.rosybrown")]
            internal sealed class DiffbolditalicRosyBrownFormat : ClassificationFormatDefinition{

                public DiffbolditalicRosyBrownFormat() { 
					this.ForegroundColor = Colors.RosyBrown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- RoyalBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.royalblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicRoyalBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.royalblue")]
            [Name("text.bolditalic.royalblue")]
            internal sealed class DiffbolditalicRoyalBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicRoyalBlueFormat() { 
					this.ForegroundColor = Colors.RoyalBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SaddleBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.saddlebrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSaddleBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.saddlebrown")]
            [Name("text.bolditalic.saddlebrown")]
            internal sealed class DiffbolditalicSaddleBrownFormat : ClassificationFormatDefinition{

                public DiffbolditalicSaddleBrownFormat() { 
					this.ForegroundColor = Colors.SaddleBrown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Salmon --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.salmon")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSalmonDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.salmon")]
            [Name("text.bolditalic.salmon")]
            internal sealed class DiffbolditalicSalmonFormat : ClassificationFormatDefinition{

                public DiffbolditalicSalmonFormat() { 
					this.ForegroundColor = Colors.Salmon; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SandyBrown --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.sandybrown")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSandyBrownDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.sandybrown")]
            [Name("text.bolditalic.sandybrown")]
            internal sealed class DiffbolditalicSandyBrownFormat : ClassificationFormatDefinition{

                public DiffbolditalicSandyBrownFormat() { 
					this.ForegroundColor = Colors.SandyBrown; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SeaGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.seagreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSeaGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.seagreen")]
            [Name("text.bolditalic.seagreen")]
            internal sealed class DiffbolditalicSeaGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicSeaGreenFormat() { 
					this.ForegroundColor = Colors.SeaGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SeaShell --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.seashell")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSeaShellDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.seashell")]
            [Name("text.bolditalic.seashell")]
            internal sealed class DiffbolditalicSeaShellFormat : ClassificationFormatDefinition{

                public DiffbolditalicSeaShellFormat() { 
					this.ForegroundColor = Colors.SeaShell; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Sienna --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.sienna")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSiennaDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.sienna")]
            [Name("text.bolditalic.sienna")]
            internal sealed class DiffbolditalicSiennaFormat : ClassificationFormatDefinition{

                public DiffbolditalicSiennaFormat() { 
					this.ForegroundColor = Colors.Sienna; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Silver --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.silver")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSilverDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.silver")]
            [Name("text.bolditalic.silver")]
            internal sealed class DiffbolditalicSilverFormat : ClassificationFormatDefinition{

                public DiffbolditalicSilverFormat() { 
					this.ForegroundColor = Colors.Silver; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SkyBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.skyblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSkyBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.skyblue")]
            [Name("text.bolditalic.skyblue")]
            internal sealed class DiffbolditalicSkyBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicSkyBlueFormat() { 
					this.ForegroundColor = Colors.SkyBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SlateBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.slateblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSlateBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.slateblue")]
            [Name("text.bolditalic.slateblue")]
            internal sealed class DiffbolditalicSlateBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicSlateBlueFormat() { 
					this.ForegroundColor = Colors.SlateBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SlateGray --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.slategray")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSlateGrayDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.slategray")]
            [Name("text.bolditalic.slategray")]
            internal sealed class DiffbolditalicSlateGrayFormat : ClassificationFormatDefinition{

                public DiffbolditalicSlateGrayFormat() { 
					this.ForegroundColor = Colors.SlateGray; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Snow --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.snow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSnowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.snow")]
            [Name("text.bolditalic.snow")]
            internal sealed class DiffbolditalicSnowFormat : ClassificationFormatDefinition{

                public DiffbolditalicSnowFormat() { 
					this.ForegroundColor = Colors.Snow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SpringGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.springgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSpringGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.springgreen")]
            [Name("text.bolditalic.springgreen")]
            internal sealed class DiffbolditalicSpringGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicSpringGreenFormat() { 
					this.ForegroundColor = Colors.SpringGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- SteelBlue --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.steelblue")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicSteelBlueDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.steelblue")]
            [Name("text.bolditalic.steelblue")]
            internal sealed class DiffbolditalicSteelBlueFormat : ClassificationFormatDefinition{

                public DiffbolditalicSteelBlueFormat() { 
					this.ForegroundColor = Colors.SteelBlue; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Tan --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.tan")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicTanDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.tan")]
            [Name("text.bolditalic.tan")]
            internal sealed class DiffbolditalicTanFormat : ClassificationFormatDefinition{

                public DiffbolditalicTanFormat() { 
					this.ForegroundColor = Colors.Tan; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Teal --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.teal")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicTealDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.teal")]
            [Name("text.bolditalic.teal")]
            internal sealed class DiffbolditalicTealFormat : ClassificationFormatDefinition{

                public DiffbolditalicTealFormat() { 
					this.ForegroundColor = Colors.Teal; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Thistle --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.thistle")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicThistleDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.thistle")]
            [Name("text.bolditalic.thistle")]
            internal sealed class DiffbolditalicThistleFormat : ClassificationFormatDefinition{

                public DiffbolditalicThistleFormat() { 
					this.ForegroundColor = Colors.Thistle; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Tomato --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.tomato")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicTomatoDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.tomato")]
            [Name("text.bolditalic.tomato")]
            internal sealed class DiffbolditalicTomatoFormat : ClassificationFormatDefinition{

                public DiffbolditalicTomatoFormat() { 
					this.ForegroundColor = Colors.Tomato; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Transparent --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.transparent")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicTransparentDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.transparent")]
            [Name("text.bolditalic.transparent")]
            internal sealed class DiffbolditalicTransparentFormat : ClassificationFormatDefinition{

                public DiffbolditalicTransparentFormat() { 
					this.ForegroundColor = Colors.Transparent; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Turquoise --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.turquoise")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicTurquoiseDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.turquoise")]
            [Name("text.bolditalic.turquoise")]
            internal sealed class DiffbolditalicTurquoiseFormat : ClassificationFormatDefinition{

                public DiffbolditalicTurquoiseFormat() { 
					this.ForegroundColor = Colors.Turquoise; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Violet --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.violet")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicVioletDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.violet")]
            [Name("text.bolditalic.violet")]
            internal sealed class DiffbolditalicVioletFormat : ClassificationFormatDefinition{

                public DiffbolditalicVioletFormat() { 
					this.ForegroundColor = Colors.Violet; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Wheat --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.wheat")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicWheatDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.wheat")]
            [Name("text.bolditalic.wheat")]
            internal sealed class DiffbolditalicWheatFormat : ClassificationFormatDefinition{

                public DiffbolditalicWheatFormat() { 
					this.ForegroundColor = Colors.Wheat; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- White --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.white")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicWhiteDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.white")]
            [Name("text.bolditalic.white")]
            internal sealed class DiffbolditalicWhiteFormat : ClassificationFormatDefinition{

                public DiffbolditalicWhiteFormat() { 
					this.ForegroundColor = Colors.White; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- WhiteSmoke --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.whitesmoke")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicWhiteSmokeDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.whitesmoke")]
            [Name("text.bolditalic.whitesmoke")]
            internal sealed class DiffbolditalicWhiteSmokeFormat : ClassificationFormatDefinition{

                public DiffbolditalicWhiteSmokeFormat() { 
					this.ForegroundColor = Colors.WhiteSmoke; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- Yellow --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.yellow")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicYellowDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.yellow")]
            [Name("text.bolditalic.yellow")]
            internal sealed class DiffbolditalicYellowFormat : ClassificationFormatDefinition{

                public DiffbolditalicYellowFormat() { 
					this.ForegroundColor = Colors.Yellow; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
                    
            /* -- YellowGreen --------------------------------------------------------  */
            [Export][Name("coloredtext.bolditalic.yellowgreen")][BaseDefinition("coloredtext")]
            internal static ClassificationTypeDefinition diffbolditalicYellowGreenDefinition = null;

            [Export(typeof(EditorFormatDefinition))]
            [ClassificationType(ClassificationTypeNames = "coloredtext.bolditalic.yellowgreen")]
            [Name("text.bolditalic.yellowgreen")]
            internal sealed class DiffbolditalicYellowGreenFormat : ClassificationFormatDefinition{

                public DiffbolditalicYellowGreenFormat() { 
					this.ForegroundColor = Colors.YellowGreen; 
					 //this.TextDecorations = System.Windows.TextDecorations.Underline;
                    this.IsBold = true;
                    this.IsItalic = true;
				}
            }
        


    }
}