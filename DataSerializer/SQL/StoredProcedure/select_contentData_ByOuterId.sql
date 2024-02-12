CREATE OR REPLACE PROCEDURE select_contentData_ByOuterId(
    IN p_id INT
)
LANGUAGE SQL
AS $$
SELECT *
FROM ContentData
WHERE OuterId = p_id;
$$;
