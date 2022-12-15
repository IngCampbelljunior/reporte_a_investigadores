DELIMITER $$

USE `bd`$$

DROP PROCEDURE IF EXISTS `Insert_ReporteInvestigacion`$$

CREATE DEFINER=`hgarcia`@`%` PROCEDURE `Insert_ReporteInvestigacion`(parEmpresa VARCHAR(4),
parnocaso VARCHAR(15),
parnodocumento VARCHAR(15),
partipodocumento VARCHAR(30),
parciudadexp VARCHAR(60),
parnombres VARCHAR(60),
parapellidos VARCHAR(60),
parfechaing DATE,
parhoraing VARCHAR(5),
parfechaacc DATE,
parhoraacci VARCHAR(5),
pardiagnos TEXT,
parinvestigador VARCHAR(15),
paraseguradora VARCHAR(30)
)
BEGIN
    INSERT INTO investigador_reporte(Empresa,Caso,Fecha_elaboracion,NoDocumento,TipoDocumento,CiudadExp,Nombres,Apellidos,FechaIngreso,HoraIngreso,Fecha_acc,Hora_acc,Diagnostico,Doc_Investigador,Aseguradora)
    VALUES(parEmpresa,parnocaso,CURRENT_DATE(),parnodocumento,partipodocumento,parciudadexp,parnombres,parapellidos,parfechaing,parhoraing,parfechaacc,parhoraacci,pardiagnos,parinvestigador,paraseguradora);
	
    SELECT 'OK' AS Msg;
    END$$

DELIMITER ;