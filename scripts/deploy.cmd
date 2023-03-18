set commit-id=%1

aws deploy create-deployment --application-name menu-manager-dev --deployment-group-name menu-manager-dev --github-location repository=jacobengel/MenuPlanner,commitId=%commit-id% --output text > deployment-id.txt

set /P deployment-id= < deployment-id.txt

:loop
aws deploy get-deployment --deployment-id %deployment-id% --query deploymentInfo.status > deployment-status.txt

set /P deployment-status= < deployment-status.txt

if %deployment-status%  neq "Succeeded" (
    timeout 30
    goto loop
)

del deployment-id.txt
del deployment-status.txt