/home/ec2-user/.dotnet/dotnet restore

/home/ec2-user/.dotnet/dotnet publish --configuration release -o /var/www/ --runtime active

systemctl enable website.service
systemctl start website.service