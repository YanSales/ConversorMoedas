# Guia de Deploy no Azure for Students

Este guia explica como implantar o **Conversor de Moedas** no Azure usando o benefício estudantil (gratuito).

---

## ✅ Pré-requisitos
1. **Conta Azure Estudante**:  
   - Registre-se em [Azure for Students](https://azure.microsoft.com/pt-bc/free/students/) com e-mail institucional.
2. **CLI do Azure**:  
   - Instale a [CLI do Azure](https://docs.microsoft.com/pt-br/cli/azure/install-azure-cli).

---

## 🚀 Passo a Passo

### 1. **Publicar o Projeto Localmente**
```bash
# Na pasta do projeto:
dotnet publish -c Release -o ./publish
```

### 2. **Fazer Login na Azure**
```bash
az login
```

### 3. **Criar Grupo de Recursos**
```bash
az group create --name ConversorMoedas-Group --location "Brazil South"
```

### 4. **Criar Plano do App Service (Free Tier)**
```bash
az appservice plan create \
    --name ConversorMoedasPlano \
    --resource-group ConversorMoedas-Group \
    --sku F1 \
    --is-linux
```

### 5. **Criar Web App**
```bash
az webapp create \
    --name conversor-moedas-2025 \  # Substitua por um nome único
    --resource-group ConversorMoedas-Group \
    --plan ConversorMoedasPlano \
    --runtime "DOTNETCORE:8.0"
```

### 6. **Configurar API Key**
```bash
az webapp config appsettings set \
    --name conversor-moedas-2025 \
    --resource-group ConversorMoedas-Group \
    --settings ExchangeRateApiKey="SUA_API_KEY_AQUI"
```

### 7. **Fazer Deploy do Código (ZIP)**
```bash
# Compacte os arquivos (Windows: use o Explorer ou PowerShell)
Compress-Archive -Path ./publish/* -DestinationPath ./deploy.zip

# Faça o deploy
az webapp deployment source config-zip \
    --src ./deploy.zip \
    --name conversor-moedas-2025 \
    --resource-group ConversorMoedas-Group
```

---

## 🌐 Acessar o Site
Seu site estará disponível em:  
**https://conversor-moedas-2025.azurewebsites.net**

---

## 🔧 Solução de Problemas
- **Erro 500**: Verifique se a API Key foi configurada corretamente.
- **Site não atualiza**: Limpe o cache do navegador ou force uma atualização (`Ctrl + F5`).
- **Problemas no deploy**:  
  ```bash
  az webapp log tail --name conversor-moedas-2024 --resource-group ConversorMoedas-Group
  ```

---

## 📌 Dicas Adicionais
- **Domínio Personalizado**:  
  Compre um domínio no [Azure Domains](https://azure.microsoft.com/pt-br/services/app-service/web/) e vincule ao Web App.
- **Monitoramento**:  
  Ative o **Application Insights** no portal Azure para rastrear erros e tráfego.

---

**Pronto!** Seu conversor está no ar e pronto para gerar receita com AdSense. 😊  
[Voltar ao README principal](README.md)
