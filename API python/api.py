from flask import Flask, jsonify

app = Flask(__name__)

produtos = [
    {"id": 1, "nome": "Notebook", "preco": 3500},
    {"id": 2, "nome": "Mouse", "preco": 80},
    {"id": 3, "nome": "Teclado", "preco": 150}
]

@app.route("/api/produtos", methods=["GET"])
def listar_produtos():
    return jsonify(produtos)

@app.route("/api/produtos/<int:id>", methods=["GET"])
def obter_produto(id):
    for produto in produtos:
        if produto["id"] == id:
            return jsonify(produto)

    return {"erro": "Produto não encontrado"}, 404


if __name__ == "__main__":
    app.run(port=5000)