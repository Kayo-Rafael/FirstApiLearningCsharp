FirstAPI - API RESTful para Gerenciamento de Usuários e Dispositivos
.NET
ASP.NET Core

Uma API RESTful simples desenvolvida em ASP.NET Core para gerenciamento de usuários e dispositivos.

📋 Funcionalidades
✅ CRUD completo de usuários

✅ Verificação de status da API

✅ Gerenciamento básico de dispositivos

✅ Endpoints para alteração de senha e atualização de perfil

🚀 Endpoints
FirstApiBaseController
GET /api/firstApi/healthyGet - Verifica o status da API (retorna "It's Working")

UserController
GET /api/user - Lista todos os usuários

GET /api/user/{id} - Obtém um usuário específico

POST /api/user - Cria um novo usuário

PUT /api/user - Atualiza um usuário existente

DELETE /api/user - Remove um usuário

PUT /api/user/change-password - Altera a senha do usuário

DeviceController
GET /api/device - Obtém a chave customizada do cabeçalho

🔧 Estrutura de Dados
User
json
{
  "Id": 1,
  "Name": "João Silva",
  "Age": 30
}
RequestRegisterUserJson
json
{
  "Name": "Maria Souza",
  "Email": "maria@example.com"
}
ResponseRegisteredUserJson
json
{
  "id": 2,
  "name": "Maria Souza",
  "email": "maria@example.com"
}
🛠️ Tecnologias Utilizadas
ASP.NET Core 6.0

Microsoft.AspNetCore.Mvc
