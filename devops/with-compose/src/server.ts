import express from 'express';
import cors from 'cors';
import bodyParser from 'body-parser';
import mongoose from 'mongoose';
import { MongoExpenseRepository } from './database/MongoExpenseRepository';
import { expensesRouter } from './routes/expenses';

async function main() {
  await mongoose.connect('mongodb://mongo:27017/expenses');

  const repo = new MongoExpenseRepository();

  const app = express();
  app.use(cors());
  app.use(bodyParser.json());
  app.use('/expenses', expensesRouter(repo));

  app.listen(3000, () => console.log('Server running on port 3000'));
}

main().catch(console.error);
