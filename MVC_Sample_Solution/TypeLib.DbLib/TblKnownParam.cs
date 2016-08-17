using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections.Generic;

namespace TypeLib.DbLib
{
    public class TblKnownParam
    {
        public static Dictionary<string, Dictionary<string, DbParameter>> Table = new Dictionary<string, Dictionary<string, DbParameter>>();
        static TblKnownParam()
        {
            // Require Size Value for Output Parameter

            #region 함수정의(DB내부함수는제외)_Job

            #region Job Add Parameter
            Table.Add("PKG_JOB.F_SET_JOB",
                new Dictionary<string, DbParameter>()
                {
                    {"PO_N_JOB_ID", new Process.DbParameterORA(){Name = "PO_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Output }},
                    {"PI_V_START_DATE", new Process.DbParameterORA(){Name = "PI_V_START_DATE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_PROCESS_LIMIT_TIME", new Process.DbParameterORA(){Name = "PI_N_PROCESS_LIMIT_TIME", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_CURRENT_MODULE", new Process.DbParameterORA(){Name = "PI_V_CURRENT_MODULE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_WAFER_CNT_TOTAL", new Process.DbParameterORA(){Name = "PI_N_WAFER_CNT_TOTAL", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_WAFER_CNT_MISSING", new Process.DbParameterORA(){Name = "PI_N_WAFER_CNT_MISSING", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_STORAGE_IMAGE_PATH", new Process.DbParameterORA(){Name = "PI_V_STORAGE_IMAGE_PATH", Type = OracleType.VarChar, Size = 500, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_STORAGE_RESULT_PATH", new Process.DbParameterORA(){Name = "PI_V_STORAGE_RESULT_PATH", Type = OracleType.VarChar, Size = 500, Direction = ParameterDirection.Input}},
                    {"PI_CL_RV_MSG_DATA", new Process.DbParameterORA(){Name = "PI_CL_RV_MSG_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input}},
                    {"PI_V_JOB_KIND", new Process.DbParameterORA(){Name = "PI_V_JOB_KIND", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_V_JOB_TYPE", new Process.DbParameterORA(){Name = "PI_V_JOB_TYPE", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Job Add Assignment Parameter
            Table.Add("PKG_JOB.F_SET_JOB_ASSIGN",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_RUNNER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_RUNNER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_RUNNER_MKL_THREAD_COUNT", new Process.DbParameterORA(){Name = "PI_N_RUNNER_MKL_THREAD_COUNT", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_RUNNER_CORE_COUNT", new Process.DbParameterORA(){Name = "PI_N_RUNNER_CORE_COUNT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_TRAINING_PATH", new Process.DbParameterORA(){Name = "PI_V_TRAINING_PATH", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Job Add iteration count
            Table.Add("PKG_JOB.F_SET_JOB_ADD",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_CUSTOMER_FILE_COUNT", new Process.DbParameterORA(){Name = "PI_N_CUSTOMER_FILE_COUNT", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Get Job type
            Table.Add("PKG_JOB.F_GET_JOB_TYPE",
                new Dictionary<string, DbParameter>()
                {
                    {"PO_V_JOB_TYPE", new Process.DbParameterORA(){Name = "PO_V_JOB_TYPE", Type = OracleType.Char, Size = 50, Direction = ParameterDirection.Output }},
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }}                    
                });
            #endregion

            #region Get Job Kind
            Table.Add("PKG_JOB.F_GET_JOB_KIND",
                new Dictionary<string, DbParameter>()
                {
                    {"PO_V_JOB_KIND", new Process.DbParameterORA(){Name = "PO_V_JOB_KIND", Type = OracleType.Char, Size = 20, Direction = ParameterDirection.Output }},
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }}                    
                });
            #endregion

            #region Get Job Assignment
            Table.Add("PKG_JOB.F_GET_JOB_ASSIGN",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }}                    
                });
            #endregion

            #region Get Rework Job List
            Table.Add("PKG_DATA_ANALYSIS.F_GET_REWORK_JOB_LIST_WIM",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_WORK_ITEM_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }}                    
                });
            #endregion

            #region Inspection Add Parameter
            Table.Add("PKG_DATA_STORE.F_SET_INSPECTION",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_FILE_NAME", new Process.DbParameterORA(){Name = "PI_V_FILE_NAME", Type = OracleType.VarChar, Size = 100, Direction = ParameterDirection.Input }},
                    {"PI_V_FILE_TIMESTAMP", new Process.DbParameterORA(){Name = "PI_V_FILE_TIMESTAMP", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_V_DEVICE_ID", new Process.DbParameterORA(){Name = "PI_V_DEVICE_ID", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_EQUIP_ID", new Process.DbParameterORA(){Name = "PI_V_EQUIP_ID", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input}},
                    {"PI_V_STEP_ID", new Process.DbParameterORA(){Name = "PI_V_STEP_ID", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_V_LOT_ID", new Process.DbParameterORA(){Name = "PI_V_LOT_ID", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input}},
                    {"PI_V_CAT_ID", new Process.DbParameterORA(){Name = "PI_V_CAT_ID", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_V_MATERIAL_ID", new Process.DbParameterORA(){Name = "PI_V_MATERIAL_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_WAFER_CNT", new Process.DbParameterORA(){Name = "PI_N_WAFER_CNT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_STORAGE_PATH", new Process.DbParameterORA(){Name = "PI_V_STORAGE_PATH", Type = OracleType.VarChar, Size = 500, Direction = ParameterDirection.Input }},
                    {"PI_V_LINE", new Process.DbParameterORA(){Name = "PI_V_LINE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_PP_ID", new Process.DbParameterORA(){Name = "PI_V_PP_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Wafer Add Parameter
            Table.Add("PKG_DATA_STORE.F_SET_WAFER",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_SEQ", new Process.DbParameterORA(){Name = "PI_V_WAFER_SEQ", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_PROCESS_ID", new Process.DbParameterORA(){Name = "PI_V_PROCESS_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_SLOT", new Process.DbParameterORA(){Name = "PI_N_SLOT", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_STAGE_GROUP_ID", new Process.DbParameterORA(){Name = "PI_V_STAGE_GROUP_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_GROUP_POINTS", new Process.DbParameterORA(){Name = "PI_N_GROUP_POINTS", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_WAFER_NAME", new Process.DbParameterORA(){Name = "PI_V_WAFER_NAME", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_STAGE_NAME", new Process.DbParameterORA(){Name = "PI_V_STAGE_NAME", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_WAFER_SIZE", new Process.DbParameterORA(){Name = "PI_N_WAFER_SIZE", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_CD_ORIENTATION_ANGLE", new Process.DbParameterORA(){Name = "PI_N_CD_ORIENTATION_ANGLE", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_WAFER_ANGLE", new Process.DbParameterORA(){Name = "PI_N_WAFER_ANGLE", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_REAL_COORDINATES", new Process.DbParameterORA(){Name = "PI_N_REAL_COORDINATES", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_USE_DIE_MAP", new Process.DbParameterORA(){Name = "PI_N_USE_DIE_MAP", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_TIME_ACQUISITION", new Process.DbParameterORA(){Name = "PI_V_TIME_ACQUISITION", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}                    
                });
            #endregion

            #region Measure Point Add Parameter
            Table.Add("PKG_DATA_STORE.F_SET_MEASURE_POINT",
                new Dictionary<string, DbParameter>()
                {
                    {"PO_V_WORK_ITEM_ID", new Process.DbParameterORA(){Name = "PO_V_WORK_ITEM_ID", Type = OracleType.Char, Size = 40, Direction = ParameterDirection.Output }},
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_SITE_ID", new Process.DbParameterORA(){Name = "PI_V_SITE_ID", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_N_REF_DIE_X", new Process.DbParameterORA(){Name = "PI_N_REF_DIE_X", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_REF_DIE_Y", new Process.DbParameterORA(){Name = "PI_N_REF_DIE_Y", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_DIE_PITCH_X", new Process.DbParameterORA(){Name = "PI_N_DIE_PITCH_X", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_DIE_PITCH_Y", new Process.DbParameterORA(){Name = "PI_N_DIE_PITCH_Y", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_MEASURE_DIE_X", new Process.DbParameterORA(){Name = "PI_N_MEASURE_DIE_X", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_MEASURE_DIE_Y", new Process.DbParameterORA(){Name = "PI_N_MEASURE_DIE_Y", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_DIE_ROW", new Process.DbParameterORA(){Name = "PI_N_DIE_ROW", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_DIE_COLOUMN", new Process.DbParameterORA(){Name = "PI_N_DIE_COLOUMN", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_IN_DIE_POINT_TAG", new Process.DbParameterORA(){Name = "PI_N_IN_DIE_POINT_TAG", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_DIE_SEQUENCE", new Process.DbParameterORA(){Name = "PI_N_DIE_SEQUENCE", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_MEASURE_X", new Process.DbParameterORA(){Name = "PI_N_MEASURE_X", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_MEASURE_Y", new Process.DbParameterORA(){Name = "PI_N_MEASURE_Y", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_FILE_NAME", new Process.DbParameterORA(){Name = "PI_V_FILE_NAME", Type = OracleType.VarChar, Size = 256, Direction = ParameterDirection.Input}},
                    {"PI_V_FILE_TIMESTAMP", new Process.DbParameterORA(){Name = "PI_V_FILE_TIMESTAMP", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_V_STORAGE_PATH", new Process.DbParameterORA(){Name = "PI_V_STORAGE_PATH", Type = OracleType.VarChar, Size = 500, Direction = ParameterDirection.Input}},
                    {"PI_CL_MEASURE_DATA", new Process.DbParameterORA(){Name = "PI_CL_MEASURE_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Fit Result Add Parameter
            Table.Add("PKG_DATA_ANALYSIS.F_SET_RESULT_WORK_ITEM",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_RESULT_ITEM_ID", new Process.DbParameterORA(){Name = "PI_V_RESULT_ITEM_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_RECIPE_ID", new Process.DbParameterORA(){Name = "PI_N_RECIPE_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_FILE_NAME", new Process.DbParameterORA(){Name = "PI_V_FILE_NAME", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_V_STORAGE_PATH", new Process.DbParameterORA(){Name = "PI_V_STORAGE_PATH", Type = OracleType.VarChar, Size = 500, Direction = ParameterDirection.Input}},
                    {"PI_V_STORAGE_IMAGE_PATH", new Process.DbParameterORA(){Name = "PI_V_STORAGE_IMAGE_PATH", Type = OracleType.VarChar, Size = 500, Direction = ParameterDirection.Input }},
                    {"PI_V_RESULT_TYPE", new Process.DbParameterORA(){Name = "PI_V_RESULT_TYPE", Type = OracleType.VarChar, Size = 10, Direction = ParameterDirection.Input}},
                    {"PI_L_FIT_RESULT_DATA", new Process.DbParameterORA(){Name = "PI_L_FIT_RESULT_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Measure Point Data Update
            Table.Add("PKG_DATA_STORE.F_MODIFY_MEASURE_DATA_BLOCK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_CL_MEASURE_DATA", new Process.DbParameterORA(){Name = "PI_CL_MEASURE_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input}}
                });
            #endregion

            #endregion

            #region 함수정의(DB내부함수는제외)_Process

            #region Communicator Status Message Parameter
            Table.Add("PKG_JOB_PROCESS.F_COMMUNICATOR_START",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_V_COMMUNICATOR_ALIASE", new Process.DbParameterORA(){Name = "PI_V_COMMUNICATOR_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_COMMUNICATOR_START", new Process.DbParameterORA(){Name = "PI_V_COMMUNICATOR_START", Type = OracleType.VarChar, Size = 19, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_JOB_PROCESS.F_COMMUNICATOR_MODIFY",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_V_COMMUNICATOR_ALIASE", new Process.DbParameterORA(){Name = "PI_V_COMMUNICATOR_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_COMMUNICATOR_MODIFY", new Process.DbParameterORA(){Name = "PI_V_COMMUNICATOR_MODIFY", Type = OracleType.VarChar, Size = 19, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_JOB_PROCESS.F_COMMUNICATOR_END",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_V_COMMUNICATOR_ALIASE", new Process.DbParameterORA(){Name = "PI_V_COMMUNICATOR_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_STATUS", new Process.DbParameterORA(){Name = "PI_V_STATUS", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_COMMUNICATOR_END", new Process.DbParameterORA(){Name = "PI_V_COMMUNICATOR_END", Type = OracleType.VarChar, Size = 19, Direction = ParameterDirection.Input}}
                });

            #endregion

            #region Loader Status Message Parameter
            Table.Add("PKG_JOB_PROCESS.F_LOADER_START",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_LOADER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_LOADER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_START", new Process.DbParameterORA(){Name = "PI_V_LOADER_START", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_JOB_PROCESS.F_LOADER_MODIFY",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_LOADER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_LOADER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_MODIFY", new Process.DbParameterORA(){Name = "PI_V_LOADER_MODIFY", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_JOB_PROCESS.F_LOADER_END",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_LOADER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_LOADER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_STATUS", new Process.DbParameterORA(){Name = "PI_V_STATUS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_END", new Process.DbParameterORA(){Name = "PI_V_LOADER_END", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Work Item Manager Status Message Parameter
            Table.Add("PKG_JOB_PROCESS.F_WORK_ITEM_MANAGER_START",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_WORK_ITEM_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WORK_ITEM_MANAGER_START", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_START", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_JOB_PROCESS.F_WORK_ITEM_MANAGER_MODIFY",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_WORK_ITEM_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WORK_ITEM_MANAGER_MODIFY", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_MODIFY", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_STATUS", new Process.DbParameterORA(){Name = "PI_V_STATUS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_JOB_PROCESS.F_WORK_ITEM_MANAGER_END",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_WORK_ITEM_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_STATUS", new Process.DbParameterORA(){Name = "PI_V_STATUS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WORK_ITEM_MANAGER_END", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_END", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Runner Status Message Parameter
            Table.Add("PKG_JOB_PROCESS.F_RUNNER_START",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_RUNNER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_RUNNER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_RUNNER_START", new Process.DbParameterORA(){Name = "PI_V_RUNNER_START", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_JOB_PROCESS.F_RUNNER_MODIFY",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_RUNNER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_RUNNER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_RUNNER_MODIFY", new Process.DbParameterORA(){Name = "PI_V_RUNNER_MODIFY", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_JOB_PROCESS.F_RUNNER_END",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_RUNNER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_RUNNER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_STATUS", new Process.DbParameterORA(){Name = "PI_V_STATUS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_RUNNER_END", new Process.DbParameterORA(){Name = "PI_V_RUNNER_END", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Deliverer Status Message Parameter
            Table.Add("PKG_JOB_PROCESS.F_DELIVERER_START",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_DELIVERER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_START", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_START", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_JOB_PROCESS.F_DELIVERER_MODIFY",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_DELIVERER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_MODIFY", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_MODIFY", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_JOB_PROCESS.F_DELIVERER_END",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_DELIVERER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_STATUS", new Process.DbParameterORA(){Name = "PI_V_STATUS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_PROCESS", new Process.DbParameterORA(){Name = "PI_V_PROCESS", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_END", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_END", Type = OracleType.VarChar, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region check status of the job finish (For deliverer Process)
            Table.Add("PKG_DATA_ANALYSIS.F_CHECK_DISTRIBUTION_FINISH",
                new Dictionary<string, DbParameter>()
                {
                    {"PO_IS_FINISH", new Process.DbParameterORA(){Name = "PO_IS_FINISH", Type = OracleType.Int32, Direction = ParameterDirection.Output }},
                    {"PI_V_WORK_ITEM_ID", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_ID", Type = OracleType.VarChar, Size = 40, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region the information of related the Configurator 
            Table.Add("PKG_JOB_PROCESS.F_CONFIGURATOR_START",
                new Dictionary<string, DbParameter>()
                {
                });

            Table.Add("PKG_JOB_PROCESS.F_CONFIGURATOR_END",
                new Dictionary<string, DbParameter>()
                {
                });
            #endregion

            #endregion

            #region 함수정의(DB내부함수는제외)_Stand

            #region Manager Information Set

            #region Communicator Set
            Table.Add("PKG_SYS_PROCESS.F_SET_COMMUNICATOR",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_COMM_ALIASE", new Process.DbParameterORA(){Name = "PI_V_COMM_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_COMM_IP", new Process.DbParameterORA(){Name = "PI_V_COMM_IP", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_COMM_PORT", new Process.DbParameterORA(){Name = "PI_V_COMM_PORT", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_COMM_USER", new Process.DbParameterORA(){Name = "PI_V_COMM_USER", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_COMM_PW", new Process.DbParameterORA(){Name = "PI_V_COMM_PW", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_MONITORING_PATH", new Process.DbParameterORA(){Name = "PI_V_MONITORING_PATH", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }},
                    {"PI_V_MONITORING_FILE_CODE", new Process.DbParameterORA(){Name = "PI_V_MONITORING_FILE_CODE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_MONITORING_INTERVAL", new Process.DbParameterORA(){Name = "PI_N_MONITORING_INTERVAL", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_WORKFLOW_COUNT", new Process.DbParameterORA(){Name = "PI_N_WORKFLOW_COUNT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_RELATIVE_PATH_EXE", new Process.DbParameterORA(){Name = "PI_V_RELATIVE_PATH_EXE", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }},
                    {"PI_N_PROCESS_LIMIT_TIME", new Process.DbParameterORA(){Name = "PI_N_PROCESS_LIMIT_TIME", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_CL_SETUP_DATA", new Process.DbParameterORA(){Name = "PI_CL_SETUP_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Distributor Set
            Table.Add("PKG_SYS_PROCESS.F_SET_WORK_ITEM_MANAGER",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_MANAGER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_MANAGER_IP", new Process.DbParameterORA(){Name = "PI_V_MANAGER_IP", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_MANAGER_PORT", new Process.DbParameterORA(){Name = "PI_V_MANAGER_PORT", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_MANAGER_USER", new Process.DbParameterORA(){Name = "PI_V_MANAGER_USER", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_MANAGER_PW", new Process.DbParameterORA(){Name = "PI_V_MANAGER_PW", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_MONITORING_PATH", new Process.DbParameterORA(){Name = "PI_V_MONITORING_PATH", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }},
                    {"PI_V_MONITORING_FILE_CODE", new Process.DbParameterORA(){Name = "PI_V_MONITORING_FILE_CODE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_MONITORING_INTERVAL", new Process.DbParameterORA(){Name = "PI_N_MONITORING_INTERVAL", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_WORKFLOW_COUNT", new Process.DbParameterORA(){Name = "PI_N_WORKFLOW_COUNT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_RELATIVE_PATH_EXE", new Process.DbParameterORA(){Name = "PI_V_RELATIVE_PATH_EXE", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }},
                    {"PI_N_PROCESS_LIMIT_TIME", new Process.DbParameterORA(){Name = "PI_N_PROCESS_LIMIT_TIME", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_CL_SETUP_DATA", new Process.DbParameterORA(){Name = "PI_CL_SETUP_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Loader Set
            Table.Add("PKG_SYS_PROCESS.F_SET_LOADER",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_LOADER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_LOADER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_IP", new Process.DbParameterORA(){Name = "PI_V_LOADER_IP", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_PORT", new Process.DbParameterORA(){Name = "PI_V_LOADER_PORT", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_USER", new Process.DbParameterORA(){Name = "PI_V_LOADER_USER", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_PW", new Process.DbParameterORA(){Name = "PI_V_LOADER_PW", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_MONITORING_PATH", new Process.DbParameterORA(){Name = "PI_V_MONITORING_PATH", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }},
                    {"PI_V_MONITORING_FILE_CODE", new Process.DbParameterORA(){Name = "PI_V_MONITORING_FILE_CODE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_MONITORING_INTERVAL", new Process.DbParameterORA(){Name = "PI_N_MONITORING_INTERVAL", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_WORKFLOW_COUNT", new Process.DbParameterORA(){Name = "PI_N_WORKFLOW_COUNT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_RELATIVE_PATH_EXE", new Process.DbParameterORA(){Name = "PI_V_RELATIVE_PATH_EXE", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }},
                    {"PI_N_PROCESS_LIMIT_TIME", new Process.DbParameterORA(){Name = "PI_N_PROCESS_LIMIT_TIME", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_CL_SETUP_DATA", new Process.DbParameterORA(){Name = "PI_CL_SETUP_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Runner Set
            Table.Add("PKG_SYS_PROCESS.F_SET_RUNNER",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_RUNNER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_RUNNER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_RUNNER_IP", new Process.DbParameterORA(){Name = "PI_V_RUNNER_IP", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_RUNNER_PORT", new Process.DbParameterORA(){Name = "PI_V_RUNNER_PORT", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_RUNNER_USER", new Process.DbParameterORA(){Name = "PI_V_RUNNER_USER", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_RUNNER_PW", new Process.DbParameterORA(){Name = "PI_V_RUNNER_PW", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_MONITORING_PATH", new Process.DbParameterORA(){Name = "PI_V_MONITORING_PATH", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }},
                    {"PI_V_MONITORING_FILE_CODE", new Process.DbParameterORA(){Name = "PI_V_MONITORING_FILE_CODE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_MONITORING_INTERVAL", new Process.DbParameterORA(){Name = "PI_N_MONITORING_INTERVAL", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_WORKFLOW_COUNT", new Process.DbParameterORA(){Name = "PI_N_WORKFLOW_COUNT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_RELATIVE_PATH_EXE", new Process.DbParameterORA(){Name = "PI_V_RELATIVE_PATH_EXE", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }},
                    {"PI_N_PROCESS_LIMIT_TIME", new Process.DbParameterORA(){Name = "PI_N_PROCESS_LIMIT_TIME", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_CL_SETUP_DATA", new Process.DbParameterORA(){Name = "PI_CL_SETUP_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Deliverer Set
            Table.Add("PKG_SYS_PROCESS.F_SET_DELIVERER",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_DELIVERER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_IP", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_IP", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_PORT", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_PORT", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_USER", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_USER", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_PW", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_PW", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_MONITORING_PATH", new Process.DbParameterORA(){Name = "PI_V_MONITORING_PATH", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }},
                    {"PI_V_MONITORING_FILE_CODE", new Process.DbParameterORA(){Name = "PI_V_MONITORING_FILE_CODE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_MONITORING_INTERVAL", new Process.DbParameterORA(){Name = "PI_N_MONITORING_INTERVAL", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_WORKFLOW_COUNT", new Process.DbParameterORA(){Name = "PI_N_WORKFLOW_COUNT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_RELATIVE_PATH_EXE", new Process.DbParameterORA(){Name = "PI_V_RELATIVE_PATH_EXE", Type = OracleType.VarChar, Size = 255, Direction = ParameterDirection.Input }},
                    {"PI_N_PROCESS_LIMIT_TIME", new Process.DbParameterORA(){Name = "PI_N_PROCESS_LIMIT_TIME", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_CL_SETUP_DATA", new Process.DbParameterORA(){Name = "PI_CL_SETUP_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Node Set
            Table.Add("PKG_SYS_PROCESS.F_SET_NODE",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_NODE_ALIASE", new Process.DbParameterORA(){Name = "PI_V_NODE_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},                    
                    {"PI_CL_SETUP_DATA", new Process.DbParameterORA(){Name = "PI_CL_SETUP_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #endregion

            #region Manager Link Information Set

            #region Distributor - Loader
            Table.Add("PKG_SYS_PROCESS.F_SET_MANAGER_LOADER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_MANAGER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_LOADER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Distributor - Runner
            Table.Add("PKG_SYS_PROCESS.F_SET_MANAGER_RUNNER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_MANAGER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_RUNNER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_RUNNER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Distributor - Deliverer
            Table.Add("PKG_SYS_PROCESS.F_SET_MANAGER_DELIVERER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_MANAGER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Runner - Node
            Table.Add("PKG_SYS_PROCESS.F_SET_RUNNER_NODE_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_RUNNER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_RUNNER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_NODE_ALIASE", new Process.DbParameterORA(){Name = "PI_V_NODE_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Communciator - Loader
            Table.Add("PKG_SYS_PROCESS.F_SET_COMM_LOADER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_COMM_ALIASE", new Process.DbParameterORA(){Name = "PI_V_COMM_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_LOADER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Communciator - Deliverer
            Table.Add("PKG_SYS_PROCESS.F_SET_COMM_DELIVERER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_COMM_ALIASE", new Process.DbParameterORA(){Name = "PI_V_COMM_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }}
                });
            #endregion

            #endregion

            #region Manager Information Query

            #region Loader Information Query Parameter
            Table.Add("PKG_SYS_PROCESS.F_GET_LOADER_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_LOADER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_LOADER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_SYS_PROCESS.F_GET_MANAGER_LOADER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_WORK_ITEM_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_LOADER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Deliverer Information Query Parameter
            Table.Add("PKG_SYS_PROCESS.F_GET_DELIVERER_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_DELIVERER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_SYS_PROCESS.F_GET_MANAGER_DELIVERER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_WORK_ITEM_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Distributor Information Query Parameter
            Table.Add("PKG_SYS_PROCESS.F_GET_WORK_ITEM_MANAGER_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_WORK_ITEM_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},                    
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Runner Information Query Parameter
            Table.Add("PKG_SYS_PROCESS.F_GET_RUNNER_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_RUNNER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_RUNNER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_SYS_PROCESS.F_GET_MANAGER_RUNNER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_WORK_ITEM_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_RUNNER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_RUNNER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Node Information Query Parameter
            Table.Add("PKG_SYS_PROCESS.F_GET_NODE_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_NODE_ALIASE", new Process.DbParameterORA(){Name = "PI_V_NODE_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_SYS_PROCESS.F_GET_RUNNER_NODE_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_RUNNER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_RUNNER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_NODE_ALIASE", new Process.DbParameterORA(){Name = "PI_V_NODE_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Communicator Information Query Parameter
            Table.Add("PKG_SYS_PROCESS.F_GET_COMMUNICATOR_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_COMM_ALIASE", new Process.DbParameterORA(){Name = "PI_V_COMM_ALIASE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_SYS_PROCESS.F_GET_COMM_LOADER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_COMM_ALIASE", new Process.DbParameterORA(){Name = "PI_V_COMM_ALIASE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_V_LOADER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_LOADER_ALIASE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_SYS_PROCESS.F_GET_COMM_DELIVERER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_COMM_ALIASE", new Process.DbParameterORA(){Name = "PI_V_COMM_ALIASE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_V_DELIVERER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_DELIVERER_ALIASE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region JobChecker Information Query Parameter
            Table.Add("PKG_SYS_PROCESS.F_GET_JOB_CHECKER_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_CHECKER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_CHECKER_ALIASE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });

            Table.Add("PKG_SYS_PROCESS.F_GET_CHECKER_MGR_COMM_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_JOB_CHECKER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_JOB_CHECKER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_WORK_ITEM_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_COMMUNICATOR_ALIASE", new Process.DbParameterORA(){Name = "PI_V_COMMUNICATOR_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #region Configurator Information Query Paramenter
            Table.Add("PKG_SYS_PROCESS.F_GET_CONFIGURATOR_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_CONFIGURATOR_ALIASE", new Process.DbParameterORA(){Name = "PI_V_CONFIGURATOR_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_DIVISION", new Process.DbParameterORA(){Name = "PI_N_DIVISION", Type = OracleType.Int32, Direction = ParameterDirection.Input}}
                });
            #endregion

            #endregion

            #endregion

            #region 함수정의(DB내부함수는제외)_Recipe

            #region Get Recipe Configure
            Table.Add("PKG_RECIPE.F_GET_RECIPE_CONFIGURE",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_DEVICE_ID", new Process.DbParameterORA(){Name = "PI_V_DEVICE_ID", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_STEP_ID", new Process.DbParameterORA(){Name = "PI_V_STEP_ID", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input}},
                    {"PI_V_SITE_ID", new Process.DbParameterORA(){Name = "PI_V_SITE_ID", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input}},
                    {"PI_V_EQUIP_ID", new Process.DbParameterORA(){Name = "PI_V_EQUIP_ID", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Get Recipe 
            Table.Add("PKG_RECIPE.F_GET_RECIPE",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_RECIPE_ID", new Process.DbParameterORA(){Name = "PI_N_RECIPE_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_RECIPE_PID", new Process.DbParameterORA(){Name = "PI_N_RECIPE_PID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_RECIPE_NAME", new Process.DbParameterORA(){Name = "PI_V_RECIPE_NAME", Type = OracleType.VarChar, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Get Recipe Data (For Runner Process)
            Table.Add("PKG_RECIPE.F_GET_RECIPE_ENGINE",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Get Runner Information for Recipe Execute (For Distributor Process)
            Table.Add("PKG_RECIPE.F_GET_RECIPE_RUNNER_LINK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WAFER_ID", new Process.DbParameterORA(){Name = "PI_V_WAFER_ID", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_N_POINT_ID", new Process.DbParameterORA(){Name = "PI_N_POINT_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Set Recipe Data..
            Table.Add("PKG_RECIPE.F_SET_RECIPE",
                new Dictionary<string, DbParameter>()
                {
                    {"PO_N_RECIPE_ID", new Process.DbParameterORA(){Name = "PO_N_RECIPE_ID", Type = OracleType.Int32, Direction = ParameterDirection.Output }},
                    {"PO_N_RECIPE_PID", new Process.DbParameterORA(){Name = "PO_N_RECIPE_PID", Type = OracleType.Int32, Direction = ParameterDirection.Output}},
                    {"PI_N_RECIPE_ID", new Process.DbParameterORA(){Name = "PI_N_RECIPE_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_RECIPE_PID", new Process.DbParameterORA(){Name = "PI_N_RECIPE_PID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_RECIPE_NAME", new Process.DbParameterORA(){Name = "PI_V_RECIPE_NAME", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_REVISION_VERSION", new Process.DbParameterORA(){Name = "PI_V_REVISION_VERSION", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_STORAGE_PATH", new Process.DbParameterORA(){Name = "PI_V_STORAGE_PATH", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_USE_YN", new Process.DbParameterORA(){Name = "PI_N_USE_YN", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_LOCKING", new Process.DbParameterORA(){Name = "PI_N_LOCKING", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_REG_IP", new Process.DbParameterORA(){Name = "PI_V_REG_IP", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_CL_MODEL_PARAMETERS", new Process.DbParameterORA(){Name = "PI_CL_MODEL_PARAMETERS", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_CL_FIT_PARAMETERS", new Process.DbParameterORA(){Name = "PI_CL_FIT_PARAMETERS", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_CL_META_PARAMETERS", new Process.DbParameterORA(){Name = "PI_CL_META_PARAMETERS", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_CL_REPORTING_PARAMETERS", new Process.DbParameterORA(){Name = "PI_CL_REPORTING_PARAMETERS", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_CL_VALUE_PARAMETERS", new Process.DbParameterORA(){Name = "PI_CL_VALUE_PARAMETERS", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_CL_CONDITIONS", new Process.DbParameterORA(){Name = "PI_CL_CONDITIONS", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_CL_STRUCTURE", new Process.DbParameterORA(){Name = "PI_CL_STRUCTURE", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_CL_INPUT_YAML", new Process.DbParameterORA(){Name = "PI_CL_INPUT_YAML", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_CL_RECIPE_TOTAL_DATA", new Process.DbParameterORA(){Name = "PI_CL_RECIPE_TOTAL_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_V_KERNEL_TYPE", new Process.DbParameterORA(){Name = "PI_V_KERNEL_TYPE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_SPECTRUM_TYPE", new Process.DbParameterORA(){Name = "PI_V_SPECTRUM_TYPE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_MEASURE_TYPE", new Process.DbParameterORA(){Name = "PI_V_MEASURE_TYPE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_SOL_ID", new Process.DbParameterORA(){Name = "PI_V_SOL_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_SOL_PID", new Process.DbParameterORA(){Name = "PI_V_SOL_PID", Type = OracleType.Int32, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Get Reporting Rule Data (For deliverer Process)
            Table.Add("PKG_RECIPE.F_GET_RECIPE_REPORTING_BLOCK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_RECIPE_ID", new Process.DbParameterORA(){Name = "PI_N_RECIPE_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Get Recipe Conditions block
            Table.Add("PKG_RECIPE.F_GET_RECIPE_CONDITIONS_BLOCK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_RECIPE_ID", new Process.DbParameterORA(){Name = "PI_N_RECIPE_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }}
                });
            #endregion

            #endregion

            #region 함수정의(DB내부함수는제외)_Solution

            #region F_SET_SOLUTION_INFO
            Table.Add("PKG_SOLUTION.F_SET_SOLUTION_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_ID", new Process.DbParameterORA(){Name = "PI_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_PID", new Process.DbParameterORA(){Name = "PI_PID", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_NAME", new Process.DbParameterORA(){Name = "PI_V_NAME", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_V_VERSION", new Process.DbParameterORA(){Name = "PI_V_VERSION", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_V_DATE", new Process.DbParameterORA(){Name = "PI_V_DATE", Type = OracleType.VarChar, Size = 19, Direction = ParameterDirection.Input }},
                    {"PI_V_WRITE_USER", new Process.DbParameterORA(){Name = "PI_V_WRITE_USER", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input}},
                    {"PI_N_SEQ_ID_MODEL", new Process.DbParameterORA(){Name = "PI_N_SEQ_ID_MODEL", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_SEQ_ID_FIT", new Process.DbParameterORA(){Name = "PI_N_SEQ_ID_FIT", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_SEQ_ID_META", new Process.DbParameterORA(){Name = "PI_N_SEQ_ID_META", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_SEQ_ID_REPORTING", new Process.DbParameterORA(){Name = "PI_N_SEQ_ID_REPORTING", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_SEQ_ID_VALUE", new Process.DbParameterORA(){Name = "PI_N_SEQ_ID_VALUE", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_SEQ_ID_CONDITION", new Process.DbParameterORA(){Name = "PI_N_SEQ_ID_CONDITION", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_SEQ_ID_STRUCTURE", new Process.DbParameterORA(){Name = "PI_N_SEQ_ID_STRUCTURE", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_SEQ_ID_YAML", new Process.DbParameterORA(){Name = "PI_N_SEQ_ID_YAML", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_SEQ_ID_MATERIAL", new Process.DbParameterORA(){Name = "PI_N_SEQ_ID_MATERIAL", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_CL_TOTAL_DATA", new Process.DbParameterORA(){Name = "PI_CL_TOTAL_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input}},
                    {"PI_V_STORAGE_PATH", new Process.DbParameterORA(){Name = "PI_V_STORAGE_PATH", Type = OracleType.VarChar, Size = 500, Direction = ParameterDirection.Input}},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_DATA_MAKE_TYPE_FLAG", new Process.DbParameterORA(){Name = "PI_N_DATA_MAKE_TYPE_FLAG", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                });
            #endregion

            #region F_GET_SOLUTION_INFO
            Table.Add("PKG_SOLUTION.F_GET_SOLUTION_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_START_DATE", new Process.DbParameterORA(){Name = "PI_V_START_DATE", Type = OracleType.VarChar, Size = 19, Direction = ParameterDirection.Input }},
                    {"PI_V_END_DATE", new Process.DbParameterORA(){Name = "PI_V_END_DATE", Type = OracleType.VarChar, Size = 19, Direction = ParameterDirection.Input }},
                    {"PI_V_NAME", new Process.DbParameterORA(){Name = "PI_V_NAME", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},

                });
            #endregion

            #region F_DEL_SOLUTION_INFO
            Table.Add("PKG_SOLUTION.F_DEL_SOLUTION_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_SOL_ID", new Process.DbParameterORA(){Name = "PI_N_SOL_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_SOL_PID", new Process.DbParameterORA(){Name = "PI_N_SOL_PID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                });
            #endregion

            #region F_GET_SOLUTION_BLOCK
            Table.Add("PKG_SOLUTION.F_GET_SOLUTION_BLOCK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_SOL_ID", new Process.DbParameterORA(){Name = "PI_N_SOL_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_N_SOL_PID", new Process.DbParameterORA(){Name = "PI_N_SOL_PID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                });
            #endregion

            #endregion

            #region 함수정의(DB내부함수는제외)_Deliverer

            #region Get result work item (For deliverer Process)
            Table.Add("PKG_DATA_DELIVER.F_GET_RESULT_WORK_ITEM",
                new Dictionary<string, DbParameter>()
            {
                {"PI_V_WORK_ITEM_ID", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_ID", Type = OracleType.VarChar, Size = 40, Direction = ParameterDirection.Input }}
            });
            #endregion

            #region modify result data block  (For deliverer Process)
            Table.Add("PKG_DATA_DELIVER.F_MODIFY_RESULT_DATA_BLOCK",
                new Dictionary<string, DbParameter>()
            {
                {"PI_V_RESULT_TYPE", new Process.DbParameterORA(){Name = "PI_V_RESULT_TYPE", Type = OracleType.VarChar, Size = 10, Direction = ParameterDirection.Input }},
                {"PI_V_WORK_ITEM_ID", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_ID", Type = OracleType.VarChar, Size = 40, Direction = ParameterDirection.Input}},
                {"PI_V_RESULT_ITEM_ID", new Process.DbParameterORA(){Name = "PI_V_RESULT_ITEM_ID", Type = OracleType.VarChar, Size = 10, Direction = ParameterDirection.Input}},
                {"PI_CL_FIT_RESULT_DATA", new Process.DbParameterORA(){Name = "PI_CL_FIT_RESULT_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input }}
            });
            #endregion 
            
            #endregion

            #region get Rendezvous data (For Communicator)
            Table.Add("PKG_DATA_DELIVER.F_GET_RV_MSG_BLOCK_IDBS",
                new Dictionary<string, DbParameter>()
            {                
                {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }}
            });
            #endregion

            #region 함수정의(DB내부함수는제외)_Option

            #region Get Option (For Communicator Process)
            Table.Add("PKG_OPTION.F_GET_OPTION",
                new Dictionary<string, DbParameter>()
            {
                {"PI_V_KEY", new Process.DbParameterORA(){Name = "PI_V_KEY", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                {"PI_V_NAME", new Process.DbParameterORA(){Name = "PI_V_NAME", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input}},
                {"PI_V_SUBNAME", new Process.DbParameterORA(){Name = "PI_V_SUBNAME", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }}
            });
            #endregion

            #endregion

            #region 함수정의(DB내부함수는 제외)_Monitor

            #region Set System Status (F_SET_SYSTEM_STATUS)
            Table.Add("PKG_MONITOR.F_SET_SYSTEM_STATUS",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_GROUP_ALIASE", new Process.DbParameterORA(){Name = "PI_V_GROUP_ALIASE", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_ACTOR", new Process.DbParameterORA(){Name = "PI_V_ACTOR", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_ACTOR_ALIASE", new Process.DbParameterORA(){Name = "PI_V_ACTOR_ALIASE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},                    
                    {"PI_N_CPU_TOTAL", new Process.DbParameterORA(){Name = "PI_N_CPU_TOTAL", Type = OracleType.Number, Direction = ParameterDirection.Input }},
                    {"PI_N_CPU_USED", new Process.DbParameterORA(){Name = "PI_N_CPU_USED", Type = OracleType.Float, Direction = ParameterDirection.Input }},
                    {"PI_V_CPU_UNIT", new Process.DbParameterORA(){Name = "PI_V_CPU_UNIT", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_MEMORY_TOTAL", new Process.DbParameterORA(){Name = "PI_N_MEMORY_TOTAL",Type = OracleType.Number, Direction = ParameterDirection.Input }},
                    {"PI_N_MEMORY_USED", new Process.DbParameterORA(){Name = "PI_N_MEMORY_USED", Type = OracleType.Number, Direction = ParameterDirection.Input }},
                    {"PI_V_MEMORY_UNIT", new Process.DbParameterORA(){Name = "PI_V_MEMORY_UNIT", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},                    
                    {"PI_V_NETWORK_IP", new Process.DbParameterORA(){Name = "PI_V_NETWORK_IP", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_NETWORK_TYPE", new Process.DbParameterORA(){Name = "PI_V_NETWORK_TYPE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_NETWORK_USED_RATIO", new Process.DbParameterORA(){Name = "PI_N_NETWORK_USED_RATIO", Type = OracleType.Float, Direction = ParameterDirection.Input }},
                    {"PI_V_NETWORK_UNIT", new Process.DbParameterORA(){Name = "PI_V_NETWORK_UNIT", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},                    
                    {"PI_V_OS", new Process.DbParameterORA(){Name = "PI_V_OS", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_CL_OTHER_DATA_BLOCK", new Process.DbParameterORA(){Name = "PI_CL_OTHER_DATA_BLOCK", Type = OracleType.Clob, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Get System Status (F_GET_SYSTEM_STATUS)
            Table.Add("PKG_MONITOR.F_GET_SYSTEM_STATUS",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_GROUP_ALIASE", new Process.DbParameterORA(){Name = "PI_V_GROUP_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_ACTOR", new Process.DbParameterORA(){Name = "PI_V_ACTOR", Type = OracleType.VarChar, Direction = ParameterDirection.Input}},
                    {"PI_V_ACTOR_ALIASE", new Process.DbParameterORA(){Name = "PI_V_ACTOR_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Del System Status (F_DEL_SYSTEM_STATUS)  // Group 의 data를 모두 지우고, 다시 입력해야 한다. (monitoring은 무조건 갱신이기 때문에)
            Table.Add("PKG_MONITOR.F_DEL_SYSTEM_STATUS",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_GROUP_ALIASE", new Process.DbParameterORA(){Name = "PI_V_GROUP_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Set Monitor Condition (F_SET_MONITOR_CONDITION)
            Table.Add("PKG_MONITOR.F_SET_MONITOR_CONDITION",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_GROUP_ALIASE", new Process.DbParameterORA(){Name = "PI_V_GROUP_ALIASE", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_ACTOR", new Process.DbParameterORA(){Name = "PI_V_ACTOR", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_USER_ID", new Process.DbParameterORA(){Name = "PI_V_USER_ID", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_CL_CONDITION_DATA_BLOCK", new Process.DbParameterORA(){Name = "PI_CL_CONDITION_DATA_BLOCK", Type = OracleType.Clob, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Get Monitor Condition (F_GET_MONITOR_CONDITION)
            Table.Add("PKG_MONITOR.F_GET_MONITOR_CONDITION",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_GROUP_ALIASE", new Process.DbParameterORA(){Name = "PI_V_GROUP_ALIASE", Type = OracleType.VarChar, Direction = ParameterDirection.Input }},
                    {"PI_V_ACTOR", new Process.DbParameterORA(){Name = "PI_V_ACTOR", Type = OracleType.VarChar, Direction = ParameterDirection.Input }}
                });
            #endregion

            #region Del Monitor Condition (F_DEL_MONITOR_CONDITION)
            Table.Add("PKG_MONITOR.F_DEL_MONITOR_CONDITION",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_GROUP_ALIASE", new Process.DbParameterORA(){Name = "PI_V_GROUP_ALIASE", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_ACTOR", new Process.DbParameterORA(){Name = "PI_V_ACTOR", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }}
                });
            #endregion

            #endregion

            #region 함수정의 JobManager

            #region F_SET_DEVICE

            Table.Add("PKG_STAND.F_SET_DEVICE",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_DEVICE_ID", new Process.DbParameterORA(){Name = "PI_V_DEVICE_ID", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_DESIGN_RULE", new Process.DbParameterORA(){Name = "PI_V_DESIGN_RULE", Type = OracleType.VarChar, Size = 300, Direction = ParameterDirection.Input }},
                    {"PI_V_DEVICE_PREFIX", new Process.DbParameterORA(){Name = "PI_V_DEVICE_PREFIX", Type = OracleType.VarChar, Size = 300, Direction = ParameterDirection.Input }},
                    {"PI_V_DESCRIPTION", new Process.DbParameterORA(){Name = "PI_V_DESCRIPTION", Type = OracleType.VarChar,Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                });
            #endregion

            #region F_SET_STEP

            Table.Add("PKG_STAND.F_SET_STEP",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_STEP_ID", new Process.DbParameterORA(){Name = "PI_V_STEP_ID", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_V_STEP_SEQ", new Process.DbParameterORA(){Name = "PI_V_STEP_SEQ", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_MODE_TYPE", new Process.DbParameterORA(){Name = "PI_V_MODE_TYPE", Type = OracleType.VarChar,Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_V_DESCRIPTION", new Process.DbParameterORA(){Name = "PI_V_DESCRIPTION", Type = OracleType.VarChar,Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                });
            #endregion

            #region F_SET_EQUIP

            Table.Add("PKG_STAND.F_SET_EQUIP",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_EQUIP_ID", new Process.DbParameterORA(){Name = "PI_V_EQUIP_ID", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_V_EQUIP_MODEL", new Process.DbParameterORA(){Name = "PI_V_EQUIP_MODEL", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_EQUIP_VERSION", new Process.DbParameterORA(){Name = "PI_V_EQUIP_VERSION", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_V_DESCRIPTION", new Process.DbParameterORA(){Name = "PI_V_DESCRIPTION", Type = OracleType.VarChar,Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                });
            #endregion

            #region F_SET_RECIPE_CONFIGURE

            Table.Add("PKG_RECIPE.F_SET_RECIPE_CONFIGURE",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_V_DEVICE_ID", new Process.DbParameterORA(){Name = "PI_V_DEVICE_ID", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_STEP_ID", new Process.DbParameterORA(){Name = "PI_V_STEP_ID", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_V_SITE_ID", new Process.DbParameterORA(){Name = "PI_V_SITE_ID", Type = OracleType.VarChar, Size = 30, Direction = ParameterDirection.Input }},
                    {"PI_V_EQUIP_ID", new Process.DbParameterORA(){Name = "PI_V_EQUIP_ID", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_V_RECIPE_ID", new Process.DbParameterORA(){Name = "PI_V_RECIPE_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_WRITE_USER", new Process.DbParameterORA(){Name = "PI_V_WRITE_USER", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input }},
                    {"PI_N_STATE", new Process.DbParameterORA(){Name = "PI_N_STATE", Type = OracleType.Int32,Direction = ParameterDirection.Input }},
                });
            #endregion

            #region F_SET_JOB_OFFLINE
            Table.Add("PKG_JOB.F_SET_JOB_OFFLINE",
                new Dictionary<string, DbParameter>()
                {
                    {"PO_N_JOB_ID", new Process.DbParameterORA(){Name = "PO_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Output }},
                    {"PI_V_START_DATE", new Process.DbParameterORA(){Name = "PI_V_START_DATE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_PROCESS_LIMIT_TIME", new Process.DbParameterORA(){Name = "PI_N_PROCESS_LIMIT_TIME", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_V_CURRENT_MODULE", new Process.DbParameterORA(){Name = "PI_V_CURRENT_MODULE", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input }},
                    {"PI_N_WAFER_CNT_TOTAL", new Process.DbParameterORA(){Name = "PI_N_WAFER_CNT_TOTAL", Type = OracleType.Int32, Direction = ParameterDirection.Input}},
                    {"PI_N_WAFER_CNT_MISSING", new Process.DbParameterORA(){Name = "PI_N_WAFER_CNT_MISSING", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_STORAGE_IMAGE_PATH", new Process.DbParameterORA(){Name = "PI_V_STORAGE_IMAGE_PATH", Type = OracleType.VarChar, Size = 500, Direction = ParameterDirection.Input}},
                    {"PI_N_PROCESS_PERCENT", new Process.DbParameterORA(){Name = "PI_N_PROCESS_PERCENT", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_V_STORAGE_RESULT_PATH", new Process.DbParameterORA(){Name = "PI_V_STORAGE_RESULT_PATH", Type = OracleType.VarChar, Size = 500, Direction = ParameterDirection.Input}},
                    {"PI_CL_RV_MSG_DATA", new Process.DbParameterORA(){Name = "PI_CL_RV_MSG_DATA", Type = OracleType.Clob, Direction = ParameterDirection.Input}},
                    {"PI_V_JOB_KIND", new Process.DbParameterORA(){Name = "PI_V_JOB_KIND", Type = OracleType.VarChar, Size = 20, Direction = ParameterDirection.Input}},
                    {"PI_V_JOB_TYPE", new Process.DbParameterORA(){Name = "PI_V_JOB_TYPE", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input}},
                    {"PI_V_JOB_NAME", new Process.DbParameterORA(){Name = "PI_V_JOB_NAME", Type = OracleType.VarChar, Size = 50, Direction = ParameterDirection.Input}},
                });
            #endregion
            #endregion

            #region 함수정의 Job

            #region F_CHECK_JOB_RESULT_INFO
            Table.Add("PKG_JOB.F_CHECK_JOB_RESULT_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PO_N_CNT", new Process.DbParameterORA(){Name = "PO_N_CNT", Type = OracleType.Int32, Direction = ParameterDirection.Output }},
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                });

            #endregion

            #region F_DEL_JOB_DATA_VIRTUAL

            Table.Add("PKG_JOB.F_DEL_JOB_DATA_VIRTUAL",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                });

            #endregion

            #region F_SET_JOB_RESTART_INIT

            Table.Add("PKG_JOB.F_SET_JOB_RESTART_INIT",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_N_JOB_ID", new Process.DbParameterORA(){Name = "PI_N_JOB_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                });

            #endregion

            #endregion

            #region 함수정의 _JobMonitoring

            #region F_GET_JOB_PROCESS_INFO

            Table.Add("PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_INFO",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_DA_START_DATE", new Process.DbParameterORA(){Name = "PI_DA_START_DATE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_DA_END_DATE", new Process.DbParameterORA(){Name = "PI_DA_END_DATE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},

                });
            #endregion

            #region F_GET_JOB_PROCESS_HIS

            Table.Add("PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_HIS",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_DA_START_DATE", new Process.DbParameterORA(){Name = "PI_DA_START_DATE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_DA_END_DATE", new Process.DbParameterORA(){Name = "PI_DA_END_DATE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_SOL_ID", new Process.DbParameterORA(){Name = "PI_SOL_ID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                    {"PI_SOL_PID", new Process.DbParameterORA(){Name = "PI_SOL_PID", Type = OracleType.Int32, Direction = ParameterDirection.Input }},
                });
            #endregion

            #region F_GET_JOB_PROCESS_QUICK

            Table.Add("PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_QUICK",
                new Dictionary<string, DbParameter>()
                {
                    {"PI_DA_START_DATE", new Process.DbParameterORA(){Name = "PI_DA_START_DATE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_DA_END_DATE", new Process.DbParameterORA(){Name = "PI_DA_END_DATE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},
                    {"PI_V_WORK_ITEM_MANAGER_ALIASE", new Process.DbParameterORA(){Name = "PI_V_WORK_ITEM_MANAGER_ALIASE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }},

                });
            #endregion

            #endregion
                        
            #region 함수정의 _Stand Exist

            Table.Add("PKG_STAND.F_EXIST_DEVICE",
                new Dictionary<string, DbParameter>()
                {
                    {
                        "PO_N_CNT",
                        new Process.DbParameterORA()
                        {
                            Name = "PO_N_CNT",
                            Type = OracleType.Int32,
                            Direction = ParameterDirection.Output
                        }
                    },
                    {
                        "PI_V_DEVICE_ID",
                        new Process.DbParameterORA()
                        {
                            Name = "PI_V_DEVICE_ID",
                            Type = OracleType.VarChar,
                            Size = 2000,
                            Direction = ParameterDirection.Input
                        }
                    },

                });

            Table.Add("PKG_STAND.F_EXIST_STEP",
                new Dictionary<string, DbParameter>()
                {
                    {
                        "PO_N_CNT",
                        new Process.DbParameterORA()
                        {
                            Name = "PO_N_CNT",
                            Type = OracleType.Int32,
                            Direction = ParameterDirection.Output
                        }
                    },
                    {
                        "PI_V_STEP_ID",
                        new Process.DbParameterORA()
                        {
                            Name = "PI_V_STEP_ID",
                            Type = OracleType.VarChar,
                            Size = 2000,
                            Direction = ParameterDirection.Input
                        }
                    },

                });

            Table.Add("PKG_STAND.F_EXIST_EQUIP",
                new Dictionary<string, DbParameter>()
                {
                    {
                        "PO_N_CNT",
                        new Process.DbParameterORA()
                        {
                            Name = "PO_N_CNT",
                            Type = OracleType.Int32,
                            Direction = ParameterDirection.Output
                        }
                    },
                    {
                        "PI_V_EQUIP_ID",
                        new Process.DbParameterORA()
                        {
                            Name = "PI_V_EQUIP_ID",
                            Type = OracleType.VarChar,
                            Size = 2000,
                            Direction = ParameterDirection.Input
                        }
                    },

                });

            #endregion

            #region etc
            Table.Add("UpdateStatus",
               new Dictionary<string, DbParameter>()
                {
                    {"PI_NONE", new Process.DbParameterORA(){Name = "PI_NONE", Type = OracleType.VarChar, Size = 2000, Direction = ParameterDirection.Input }}
                });
            #endregion

        }
    }
}
