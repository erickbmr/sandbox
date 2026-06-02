FROM node:18-alpine AS builder
WORKDIR /app
COPY package*.json ./
COPY . .
RUN npm install
RUN npm run build

FROM node:18-alpine AS final
WORKDIR /app
COPY --from=builder /app/dist ./dist
COPY package*.json ./
RUN npm install --production
CMD ["npm", "start"]
EXPOSE 3000