import { Router, Request, Response } from 'express';
import { IExpenseRepository } from '../database/IExpenseRepository';

export function expensesRouter(repo: IExpenseRepository): Router {
  const router = Router();

  router.post('/', async (req: Request, res: Response) => {
    const { name, value } = req.body;

    if (!name || value === undefined) {
      res.status(400).json({ error: 'name and value are required' });
      return;
    }

    const expense = await repo.create(name, value);
    res.status(201).json(expense);
  });

  router.get('/', async (_req: Request, res: Response) => {
    const expenses = await repo.findAll();
    res.json(expenses);
  });

  return router;
}
