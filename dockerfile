# First our virtual OS will need the .NET 5.0 SDK
# We can utilize docker hub to access one of the published images from .NET themselves
from mcr.microsoft.com/dotnet/sdk:5.0 as build

#Setting our working directory
workdir /app

# Time to copy our porjects and paste it to the working directory
# * it is the wildcard meaning it'll grab anything in your folder that has .sln extension
copy *.sln ./
copy CRUSBL/*.csproj CRUSBL/
copy CRUSDL/*.csproj CRUSDL/
copy CRUSModels/*.csproj CRUSModels/
copy RRTest/*.csproj RRTest/
copy CRUSWebUI/*.csproj CRUSWebUI/

# We need to build/restore our files (bin & obj)
run cd CRUSWebUI && dotnet restore

# copy the source files
copy . ./
cmd /bin/bash 
# It was to check if it copied everything and restored everything

# We need to publish the application and its dependencies to a folder for deployment
run dotnet publish CRUSWebUI -c Release -o publish --no-restore

# We change our base image to be the runtime since we already used the SDK to create the application itself
# This is to use a lot less memory
from mcr.microsoft.com/dotnet/aspnet:5.0 as runtime

workdir /app
copy --from=build /app/publish ./

cmd ["dotnet", "CRUSWebUI.dll"]