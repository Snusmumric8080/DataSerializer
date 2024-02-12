CREATE OR REPLACE PROCEDURE select_contentData_ById(
    IN p_id INT
)
LANGUAGE SQL
AS $$
SELECT *
FROM ContentData
WHERE Id = p_id;
$$;
