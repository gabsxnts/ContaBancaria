class Banco:
    def __init__(self, nome, codigo):
        self._nome = nome
        self._codigo = codigo

    @property
    def nome(self):
        return self._nome.upper()

    @nome.setter
    def nome(self, valor):
        self._nome = valor

class Transacao:
    def __init__(self, valor):
        self._valor = 0
        self.valor = valor

    @property
    def valor(self):
        return self._valor

    @valor.setter
    def valor(self, novo_valor):
        if novo_valor > 0:
            self._valor = novo_valor
        else:
            print("Fiscalização: Bloqueada tentativa de valor negativo!")

if __name__ == "__main__":
    banco_exemplo = Banco("itau", "0341")
    print(f"Validando Banco: {banco_exemplo.nome}")
    
    trans_exemplo = Transacao(-100)