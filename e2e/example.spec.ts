import { expect, test } from '@playwright/test';

test('shows app greeting', async ({ page }) => {
  await page.goto('/');

  await expect(page.locator('app-root')).toContainText('Hello');
});
