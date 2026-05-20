# Passo 1 — Compilar

Dentro da pasta `udp-pinger/`:

```bash
javac Server.java Client.java
```

Isso gera `Server.class` e `Client.class`.

---

# Passo 2 — Iniciar o Servidor

Em um terminal, suba o servidor passando uma porta como argumento:

```bash
java Server 9000
```

O servidor fica aguardando pacotes na porta `9000`. Ele simula:
- 30% de perda de pacotes (`LOSS_RATE = 0.3`)
- Atraso aleatório de até 200ms (`AVERAGE_DELAY = 100ms`)

---

# Passo 3 — Executar o Cliente

Em outro terminal, rode o cliente passando o host e a porta:

```bash
java Client localhost 9000
```

O cliente envia 10 pings e exibe o RTT de cada resposta. O timeout por ping é de 1 segundo.
