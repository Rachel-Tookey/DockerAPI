# 1. Set base image 
FROM mcr.microsoft.com/dotnet/sdk:8.0

# 2. Set working directory to /APP
WORKDIR /App

# 3. Copy source code and restore dependencies 
COPY . ./
RUN dotnet restore 

# 4. build and publish the app
RUN dotnet publish -c Release -o out

# 5. Set the working directory to the output folder 
WORKDIR /App/out

# 6. Run the application via the .dll file 
ENTRYPOINT ["dotnet", "DockerAPI.dll"]

# 7. Expose a port to listen on 
EXPOSE 8080 

# 8. Configure ASP.NET
ENV ASPNETCORE_URLS=http://+:8080
