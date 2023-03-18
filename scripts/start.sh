sudo /home/ec2-user/.dotnet/dotnet restore /var/www/MenuPlanner.Host/MenuPlanner.Host.csproj

sudo /home/ec2-user/.dotnet/dotnet publish /var/www/MenuPlanner.Host/MenuPlanner.Host.csproj --configuration release -o /var/www/app/ --runtime linux-x64

systemctl enable website.service
systemctl start website.service