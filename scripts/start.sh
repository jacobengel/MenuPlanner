dotnet restore

dotnet publish --configuration release -o /var/www/ --runtime active

systemctl enable website.service
systemctl start website.service