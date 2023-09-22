### Brief demo to show Alpine issues with IronPDF

To verify: `$ docker build .`

### Output


[6/6] RUN dotnet run
Initializing
Unhandled exception. IronSoftware.Exceptions.IronSoftwareDeploymentException: Error while deploying IronPdf Chrome renderer: 'Error relocating /source/bin/Debug/net7.0/runtimes/linux-x64/native/IronInterop.so: __vswprintf_chk: symbol not found'. To learn more about making an engineering support request please visit: <a href=https://ironpdf.com/troubleshooting/engineering-request-pdf/>.

To learn how to solve this issue please read https://ironpdf.com/docs/questions/docker-linux/ [Issue Code IRONPDF-CHROME-DEPLOYMENT-ERROR-DOCKER-LINUX]
 ---> IronSoftware.Exceptions.IronSoftwareAssemblyLoadException: Error relocating /source/bin/Debug/net7.0/runtimes/linux-x64/native/IronInterop.so: __vswprintf_chk: symbol not found
   at IronSoftware.Deployment.SmartDeploymentBase.ThrowRelevantException(List`1 exceptions)
   at IronSoftware.Deployment.SmartDeploymentBase.Deploy(Boolean download)
   at IronSoftware.Deployment.DeploymentEngine.Deploy[T](String custom_dir, Boolean download)
   --- End of inner exception stack trace ---
   at IronSoftware.Deployment.DeploymentEngine.Deploy[T](String custom_dir, Boolean download)
   at IronPdf.Installation.Initialize()
   at Program.<Main>$(String[] args) in /source/Program.cs:line 8
ERROR: process "/bin/sh -c dotnet run" did not complete successfully: exit code: 134
