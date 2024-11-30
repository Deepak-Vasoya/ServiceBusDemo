# 🚀 Azure Service Bus Demo Web API

![.NET 6](https://img.shields.io/badge/.NET-6.0-blue?style=flat-square&logo=dotnet) 
![Azure Service Bus](https://img.shields.io/badge/Azure-Service_Bus-blue?style=flat-square&logo=microsoft-azure) 
![Swagger UI](https://img.shields.io/badge/Swagger-UI-green?style=flat-square&logo=swagger)

This project demonstrates how to use **Azure Service Bus** with a Web API to send messages asynchronously to a queue.

---

## ✨ Features

- 📡 **RESTful Web API**: Post messages to Azure Service Bus queues.
- 🛠️ **Swagger UI Integration**: Test and interact with API endpoints easily.
- ⚡ **Asynchronous Messaging**: Ensure reliable communication with decoupled systems.
- ☁️ **Cloud-Ready**: Built to integrate seamlessly with Azure infrastructure.

---

## 🏗️ Architecture

+------------+         +--------------------+
|  Web API   | ----->  | Azure Service Bus  |
+------------+         +--------------------+

Web API: Sends messages to Azure Service Bus.

Azure Service Bus: Acts as the message broker for communication between systems.

🛠️ Prerequisites
.NET 6 SDK
Azure Service Bus connection string (Learn more)

📖 API Endpoints
Method	Endpoint	Description
POST	/api/messages	Send a message to the queue

🛡️ License
This project is licensed under the MIT License.

🤝 Contributing
Contributions are welcome! Please fork the repository, make your changes, and submit a pull request.

