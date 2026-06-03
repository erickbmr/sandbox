# yt-dlp Docker

Baixe músicas e vídeos via linha de comando usando Docker. Nenhuma instalação além do Docker é necessária.

---

## Build

Na pasta onde está o `Dockerfile`, rode:

```bash
docker build -t yt-dlp .
```

---

## Baixar um único vídeo/música em MP3

```bash
docker run --rm -v "$(pwd):/downloads" yt-dlp -x --audio-format mp3 --audio-quality 0 "https://URL_DO_VIDEO"
```

---

## Baixar uma lista de links em MP3

1. Crie um arquivo `links.txt` na pasta atual com um link por linha:

```
https://www.platform.com/watch?v=VIDEO1
https://www.platform.com/watch?v=VIDEO2
https://www.platform.com/watch?v=VIDEO3
```

> Linhas começando com `#` são ignoradas e podem ser usadas como comentários.

2. Execute:

```bash
docker run --rm -v "$(pwd):/downloads" yt-dlp -x --audio-format mp3 --audio-quality 0 -a /downloads/links.txt
```

---

## Referência das flags

| Flag | Descrição |
|---|---|
| `--rm` | Remove o container automaticamente após terminar |
| `-v "$(pwd):/downloads"` | Monta a pasta atual para salvar os arquivos |
| `-x` | Extrai somente o áudio |
| `--audio-format mp3` | Converte para MP3 |
| `--audio-quality 0` | Melhor qualidade disponível |
| `-a links.txt` | Lê URLs a partir de um arquivo de texto |