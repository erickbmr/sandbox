# yt-dlp Docker Image
# Base: Ubuntu LTS (slim)
FROM ubuntu:24.04
 
# Evita prompts interativos durante apt
ENV DEBIAN_FRONTEND=noninteractive
 
# Instala dependências essenciais:
# - python3 + pip: yt-dlp é escrito em Python
# - ffmpeg: necessário para mesclar streams de vídeo/áudio e conversões
# - curl: fallback de download / verificação de atualizações
RUN apt-get update && apt-get install -y \
    python3 \
    python3-pip \
    ffmpeg \
    curl \
    ca-certificates \
    && rm -rf /var/lib/apt/lists/*
 
# Instala yt-dlp via pip (versão mais recente)
RUN pip3 install --no-cache-dir --break-system-packages yt-dlp
 
# Diretório padrão de saída dos downloads
WORKDIR /downloads
 
# Entrypoint aponta direto para o yt-dlp,
# então tudo após "docker run" vira argumento dele
ENTRYPOINT ["yt-dlp"]
 
# Exemplo de uso padrão (exibe ajuda se nenhum argumento for passado)
CMD ["--help"]
 
