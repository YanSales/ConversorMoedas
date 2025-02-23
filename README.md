# Conversor de Moedas Online 💰

[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/)
[![AdSense](https://img.shields.io/badge/AdSense-Enabled-FFCA28)](https://adsense.google.com/)

Um conversor de moedas simples desenvolvido em C# (ASP.NET Core) para conversões em tempo real, com integração de anúncios do Google AdSense.

![Preview](https://via.placeholder.com/800x400.png?text=Preview+Conversor+Moedas+%7C+An%C3%BAncios+AdSense)

## 🌐 **Link do Site**
<!-- INSIRA SEU LINK APÓS O DEPLOY -->
🔗 **Site ao vivo**: [https://conversor-moedas-2025.azurewebsites.net/](https://conversor-moedas-2025.azurewebsites.net/) 

## ✨ Funcionalidades
- Conversão em tempo real (USD, BRL, EUR, BTC)
- Taxas de câmbio atualizadas via API
- Design minimalista e responsivo
- Integração estratégica de anúncios AdSense

## 🛠️ Pré-requisitos
- [.NET SDK 8.0](https://dotnet.microsoft.com/download)
- Conta no [Google AdSense](https://www.google.com/adsense)
- API Key gratuita do [ExchangeRate-API](https://www.exchangerate-api.com/)

## 🚀 Instalação

# Clone o repositório
git clone https://github.com/YanSales/ConversorMoedas.git

# Entre na pasta do projeto
cd conversor-moedas

# Instale as dependências
dotnet restore

# Execute o projeto
dotnet run


## ⚙️ Configuração
1. **API Key**:
   - Registre-se no [ExchangeRate-API](https://www.exchangerate-api.com/)
   - Adicione a chave em `appsettings.json`:
    
     {
       "ExchangeRateApiKey": "SUA_CHAVE_AQUI"
     }
    

2. **AdSense**:
   - Substitua `ca-pub-XXXXX` e `data-ad-slot` no arquivo `Index.cshtml` pelos códigos da sua conta.

## 📦 Deploy no Azure
Siga o [guia de deploy no Azure for Students](DEPLOY.md) para hospedar gratuitamente.

## 📄 Licença
[MIT License](LICENSE)

---

Feito com ❤️ por [Yan Sales](https://github.com/YanSales) | [![Buy Me a Coffee](https://img.shields.io/badge/Buy_Me_A_Coffee-FFDD00?style=flat)](https://www.buymeacoffee.com/seu-usuario)

