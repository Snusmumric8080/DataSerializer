CREATE OR REPLACE PROCEDURE update_contentData(
    IN p_id INT,
    IN p_outer_id INT,
    IN p_outer_user_id INT,
    IN p_created TIMESTAMP,
    IN p_content TEXT,
    IN p_guid UUID
)
LANGUAGE SQL
AS $$
UPDATE ContentData
SET OuterId = p_outer_id,
    OuterUserId = p_outer_user_id,
    "Created" = p_created,
    "Content" = p_content,
    Guid = p_guid
WHERE Id = p_id;
$$;
