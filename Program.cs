Console.WriteLine("Initializing");

IronPdf.Logging.Logger.EnableDebugging = true;

Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
Installation.LinuxAndDockerDependenciesAutoConfig = false;

Installation.Initialize();

Console.WriteLine("Generating");

var renderer = new ChromePdfRenderer();
var pdf1 = renderer.RenderHtmlAsPdf("<p>Page 1</p>");
var pdf2 = renderer.RenderHtmlAsPdf("<p>Page 2</p>");

var merged = PdfDocument.Merge(new []{ pdf1, pdf2});

Console.WriteLine("Success");
