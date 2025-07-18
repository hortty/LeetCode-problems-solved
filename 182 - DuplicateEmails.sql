/* https://leetcode.com/problems/duplicate-emails/description/ */
  
SELECT Email
FROM Person
WHERE Email IN (
  SELECT Email
  FROM Person
  GROUP BY Email
  HAVING COUNT(*) > 1
)
GROUP BY Email;
