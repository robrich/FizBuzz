REM Clean build artifacts

REM @echo off
pushd %~dp0

dotnet clean
rmdir /s /q dist
rmdir /s /q FizBuzzConsole\bin
rmdir /s /q FizBuzzConsole\obj
rmdir /s /q FizBuzzLib\bin
rmdir /s /q FizBuzzLib\obj
rmdir /s /q FizBuzzTests\bin
rmdir /s /q FizBuzzTests\obj
rmdir /s /q FizBuzzTests\TestResults

popd
