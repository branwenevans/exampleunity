export UNITY_DOTNET_TEST=$(dirname $UNITY_EXE)/../NetCore/Sdk/dotnet
echo $UNITY_DOTNET_TEST
$UNITY_DOTNET_TEST
printenv
