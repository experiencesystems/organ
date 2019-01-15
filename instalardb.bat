SQLLocalDB stop

SQLLocalDB start

sqlcmd -E -S "(localdb)\MSSQLLocalDB" -i "C:\Program Files\More Experience Systems\Organ\dbOrgan.sql" -b

cd "C:\Program Files\More Experience Systems\Organ"

del dbOrgan.sql