# ESP32 com C# usando .NET nanoFramework
Repositório para testar as funcionalidades do .NET nanoFramework na ESP32.

## Configuração do Ambiente de Desenvolvimento
### Abrir o visual studio installer e garantir que os seguintes componentes estejam instalados:

No visual studio vá em extensões => gerenciador de extensões
Instale a extensão do nanoFramework

Abra a linha de comandos e use o comando para installar o nanoff 

`dotnet tool install -g nanoff`

Conecte a ESP32 ao USE e confira a porta COM dela. Execute o comando na porta COM correspondente.

`nanoff --target ESP32 --serialport COM3 --update --baud 115200`


