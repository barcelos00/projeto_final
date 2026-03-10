import requests

url = "http://localhost:5000/api/produtos"

try:
    resposta = requests.get(url)

    if resposta.status_code == 200:
        dados = resposta.json()

        print("Produtos recebidos da API:")

        for p in dados:
            print(f"ID: {p['id']} - Nome: {p['nome']} - Preço: {p['preco']}")
    else:
        print("Erro:", resposta.status_code)

except Exception as e:
    print("Erro ao conectar:", e)