REM Build FizBuzz library

REM TODO: move this environment variable to build server
set PackageVersion=1.1.1

REM @echo off
pushd %~dp0

dotnet restore || exit /b 1
dotnet build -c Release -p:PackageVersion=%PackageVersion% || exit /b 1
dotnet test || exit /b 1
REM test results are in FizBuzzTests\TestResults

mkdir dist
pushd FizBuzzLib
dotnet pack -o ..\dist -p:PackageVersion=%PackageVersion% || exit /b 1
popd ..

popd
