CREATE OR REPLACE PROCEDURE insert_ContentData(
    IN p_outer_id INT,
    IN p_outer_user_id INT,
    IN p_created TIMESTAMP,
    IN p_content TEXT,
    IN p_guid UUID
    
)
LANGUAGE SQL
AS $$
INSERT INTO ContentData (OuterId, OuterUserId, "Created", "Content", Guid)
VALUES (p_outer_id, p_outer_user_id, p_created, p_content, p_guid)
RETURNING Id;
$$;