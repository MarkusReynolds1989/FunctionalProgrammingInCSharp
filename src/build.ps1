"`n`n`n=============================================="
"Cleaning..."
git clean -xdf
dotnet clean /tl
"`n`n`n=============================================="

"Building..."
dotnet build /tl
"`n`n`n=============================================="

"Testing..."
dotnet test /tl

