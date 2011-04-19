
CREATE view Stok_gruplari
as
SELECT SLB, SLT,SLVV,SLXX,SLYY from KEYDAT 
where SLK='30' and (SLB like '09%'  OR SLB like '16%' )



