﻿using System;
using System.Collections.Generic;

namespace TypeLib.DbLib
{
    public class TblQueryContents
    {
        public static Dictionary<string, string> Table = new Dictionary<string,string>();
        static TblQueryContents()
        {
            #region Function Define(Except DB inline Function)_Job

            //F_SET_JOB : 0 [Success] / 1 [Fail] / 5 [ERR_TOO_MANY_ROWS] 
            Table.Add(@"PKG_JOB.F_SET_JOB",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_SET_JOB(:PO_V_ERR, :PO_N_JOB_ID, " +
                @":PI_V_START_DATE, :PI_N_PROCESS_LIMIT_TIME, :PI_V_CURRENT_MODULE, :PI_N_WAFER_CNT_TOTAL, " +
                @":PI_N_WAFER_CNT_MISSING, :PI_V_STORAGE_IMAGE_PATH, :PI_N_PROCESS_PERCENT, :PI_V_STORAGE_RESULT_PATH, " +
                @":PI_CL_RV_MSG_DATA, :PI_V_JOB_KIND, :PI_V_JOB_TYPE); END;");

            //F_SET_JOB_ASSIGN : 0 [Success] / 1 [Fail] / 3 [ERR_NOT_EXIST] 
            Table.Add(@"PKG_JOB.F_SET_JOB_ASSIGN",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_SET_JOB_ASSIGN(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_RUNNER_ALIASE, :PI_N_RUNNER_MKL_THREAD_COUNT, :PI_N_RUNNER_CORE_COUNT, :PI_V_TRAINING_PATH); END;");

            //F_SET_JOB_ADD : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_JOB.F_SET_JOB_ADD",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_SET_JOB_ADD(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_N_CUSTOMER_FILE_COUNT); END;");

            //F_GET_JOB_TYPE : 0 [Success] / 1 [Fail]  
            Table.Add(@"PKG_JOB.F_GET_JOB_TYPE",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_GET_JOB_TYPE(:PO_V_ERR, :PO_V_JOB_TYPE, " +
                @":PI_N_JOB_ID); END;");

            //F_GET_JOB_KIND : 0 [Success] / 1 [Fail]  
            Table.Add(@"PKG_JOB.F_GET_JOB_KIND",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_GET_JOB_KIND(:PO_V_ERR, :PO_V_JOB_KIND, " +
                @":PI_N_JOB_ID); END;");

            //F_GET_JOB_ASSIGN : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB.F_GET_JOB_ASSIGN",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_GET_JOB_ASSIGN(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_JOB_ID); END;");

            //F_MODIFY_JOB_STATUS : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_JOB.F_MODIFY_JOB_STATUS",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_MODIFY_JOB_STATUS(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_JOB_STATUS, :PI_V_CURRENT_MODULE, :PI_V_END_DATE); END;");

            //F_SET_INSPECTION : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_DATA_STORE.F_SET_INSPECTION",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_STORE.F_SET_INSPECTION(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_FILE_NAME, :PI_V_FILE_TIMESTAMP, " +
                @":PI_V_DEVICE_ID, :PI_V_EQUIP_ID, :PI_V_STEP_ID, :PI_V_LOT_ID, :PI_V_CAT_ID, " +
                @":PI_V_MATERIAL_ID, :PI_N_WAFER_CNT, :PI_V_STORAGE_PATH, :PI_V_LINE, :PI_V_PP_ID); END;");

            //F_SET_WAFER : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_DATA_STORE.F_SET_WAFER",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_STORE.F_SET_WAFER(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_V_WAFER_SEQ, :PI_V_PROCESS_ID, :PI_N_SLOT, :PI_V_STAGE_GROUP_ID, " +
                @":PI_N_GROUP_POINTS, :PI_V_WAFER_NAME, :PI_V_STAGE_NAME, :PI_N_WAFER_SIZE, :PI_N_CD_ORIENTATION_ANGLE, " +
                @":PI_N_WAFER_ANGLE, :PI_N_REAL_COORDINATES, :PI_N_USE_DIE_MAP, :PI_V_TIME_ACQUISITION); END;");

            //F_SET_MEASURE_POINT : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_DATA_STORE.F_SET_MEASURE_POINT",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_STORE.F_SET_MEASURE_POINT(:PO_V_ERR, :PO_V_WORK_ITEM_ID, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID, :PI_V_SITE_ID, :PI_N_REF_DIE_X, :PI_N_REF_DIE_Y, " +
                @":PI_N_DIE_PITCH_X, :PI_N_DIE_PITCH_Y, :PI_N_MEASURE_DIE_X, :PI_N_MEASURE_DIE_Y, :PI_N_DIE_ROW, " +
                @":PI_N_DIE_COLOUMN, :PI_N_IN_DIE_POINT_TAG, :PI_N_DIE_SEQUENCE, :PI_N_MEASURE_X, :PI_N_MEASURE_Y, " +
                @":PI_V_FILE_NAME, :PI_V_FILE_TIMESTAMP, :PI_V_STORAGE_PATH, :PI_CL_MEASURE_DATA); END;");

            //F_SET_RESULT_WORK_ITEM : 0 [Success] / 1 [Fail] / 3 [ERR_NOT_EXIST]
            Table.Add(@"PKG_DATA_ANALYSIS.F_SET_RESULT_WORK_ITEM",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_ANALYSIS.F_SET_RESULT_WORK_ITEM(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID, :PI_V_RESULT_ITEM_ID, :PI_N_RECIPE_ID, :PI_V_FILE_NAME, " +
                @":PI_V_STORAGE_PATH, :PI_V_STORAGE_IMAGE_PATH, :PI_V_RESULT_TYPE, :PI_L_FIT_RESULT_DATA); END;");

            //F_GET_REWORK_JOB_LIST : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_DATA_ANALYSIS.F_GET_REWORK_JOB_LIST",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_ANALYSIS.F_GET_REWORK_JOB_LIST(:PO_V_ERR, :PO_CUR); END;");

            //F_GET_REWORK_ITEM_LIST : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_DATA_ANALYSIS.F_GET_REWORK_ITEM_LIST",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_ANALYSIS.F_GET_REWORK_ITEM_LIST(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_JOB_ID); END;");

            //F_GET_REWORK_JOB_LIST_WIM : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_DATA_ANALYSIS.F_GET_REWORK_JOB_LIST_WIM",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_ANALYSIS.F_GET_REWORK_JOB_LIST_WIM(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_WORK_ITEM_MANAGER_ALIASE); END;");

            //F_MODIFY_MEASURE_DATA_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_DATA_STORE.F_MODIFY_MEASURE_DATA_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_STORE.F_MODIFY_MEASURE_DATA_BLOCK(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID, :PI_CL_MEASURE_DATA); END;");

            #endregion

            #region Function Define(Except DB inline Function)_Process

            #region Communicator Status Message
            // F_COMMUNICATOR_START : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_COMMUNICATOR_START",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_COMMUNICATOR_START(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_V_COMMUNICATOR_ALIASE, :PI_V_PROCESS, :PI_N_PROCESS_PERCENT, :PI_V_COMMUNICATOR_START); END;");

            // F_COMMUNICATOR_MODIFY : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_COMMUNICATOR_MODIFY",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_COMMUNICATOR_MODIFY(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_V_COMMUNICATOR_ALIASE, :PI_V_PROCESS, :PI_N_PROCESS_PERCENT, :PI_V_COMMUNICATOR_MODIFY); END;");

            // F_COMMUNICATOR_END : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_COMMUNICATOR_END",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_COMMUNICATOR_END(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_V_COMMUNICATOR_ALIASE, :PI_V_STATUS, :PI_V_PROCESS, :PI_N_PROCESS_PERCENT, :PI_V_COMMUNICATOR_END); END;");
            #endregion

            #region Loader Status Message
            //F_LOADER_START : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_LOADER_START",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_LOADER_START(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_V_LOADER_ALIASE, :PI_V_PROCESS, :PI_N_PROCESS_PERCENT, :PI_V_LOADER_START); END;");

            //F_LOADER_MODIFY : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_LOADER_MODIFY",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_LOADER_MODIFY(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_V_LOADER_ALIASE, :PI_V_PROCESS, :PI_N_PROCESS_PERCENT, :PI_V_LOADER_MODIFY); END;");

            //F_LOADER_END : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_LOADER_END",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_LOADER_END(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_V_LOADER_ALIASE, :PI_V_STATUS, :PI_V_PROCESS, :PI_N_PROCESS_PERCENT, :PI_V_LOADER_END); END;");
            #endregion

            #region Work Item Manager Status Message
            //F_WORK_ITEM_MANAGER_START : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_WORK_ITEM_MANAGER_START",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_WORK_ITEM_MANAGER_START(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID, :PI_V_WORK_ITEM_MANAGER_ALIASE, :PI_V_PROCESS, " +
                @":PI_N_PROCESS_PERCENT, :PI_V_WORK_ITEM_MANAGER_START); END;");

            //F_WORK_ITEM_MANAGER_MODIFY : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_WORK_ITEM_MANAGER_MODIFY",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_WORK_ITEM_MANAGER_MODIFY(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID, :PI_V_WORK_ITEM_MANAGER_ALIASE, :PI_V_PROCESS, " +
                @":PI_N_PROCESS_PERCENT, :PI_V_WORK_ITEM_MANAGER_MODIFY, :PI_V_STATUS); END;");

            //F_WORK_ITEM_MANAGER_END : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_WORK_ITEM_MANAGER_END",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_WORK_ITEM_MANAGER_END(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID, :PI_V_WORK_ITEM_MANAGER_ALIASE, :PI_V_STATUS, :PI_V_PROCESS, " +
                @":PI_N_PROCESS_PERCENT, :PI_V_WORK_ITEM_MANAGER_END); END;");
            #endregion

            #region Runner Status Message
            //F_RUNNER_START : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_RUNNER_START",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_RUNNER_START(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID, :PI_V_RUNNER_ALIASE, :PI_V_PROCESS, " +
                @":PI_N_PROCESS_PERCENT, :PI_V_RUNNER_START); END;");

            //F_RUNNER_MODIFY : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_RUNNER_MODIFY",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_RUNNER_MODIFY(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID, :PI_V_RUNNER_ALIASE, :PI_V_PROCESS, " +
                @":PI_N_PROCESS_PERCENT, :PI_V_RUNNER_MODIFY); END;");

            //F_RUNNER_END : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_RUNNER_END",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_RUNNER_END(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID, :PI_V_RUNNER_ALIASE, :PI_V_STATUS, :PI_V_PROCESS, " +
                @":PI_N_PROCESS_PERCENT, :PI_V_RUNNER_END); END;");
            #endregion

            #region Deliverer Status Message
            //F_DELIVERER_START : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_DELIVERER_START",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_DELIVERER_START(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_V_DELIVERER_ALIASE, :PI_V_PROCESS, " +
                @":PI_N_PROCESS_PERCENT, :PI_V_DELIVERER_START); END;");

            //F_DELIVERER_MODIFY : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_DELIVERER_MODIFY",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_DELIVERER_MODIFY(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_V_DELIVERER_ALIASE, :PI_V_PROCESS, " +
                @":PI_N_PROCESS_PERCENT, :PI_V_DELIVERER_MODIFY); END;");

            //F_DELIVERER_END : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_PROCESS.F_DELIVERER_END",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_PROCESS.F_DELIVERER_END(:PO_V_ERR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_V_DELIVERER_ALIASE, :PI_V_STATUS, :PI_V_PROCESS, " +
                @":PI_N_PROCESS_PERCENT, :PI_V_DELIVERER_END); END;");
            #endregion

            //F_CHECK_DISTRIBUTION_FINISH : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_DATA_ANALYSIS.F_CHECK_DISTRIBUTION_FINISH",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_ANALYSIS.F_CHECK_DISTRIBUTION_FINISH(:PO_V_ERR, :PO_IS_FINISH, " +
                @":PI_V_WORK_ITEM_ID); END;");

            #endregion

            #region Function Define(Except DB inline Function)_Option

            //F_GET_OPTION : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_OPTION.F_GET_OPTION",
                @"BEGIN :PO_I_RETURN:=PKG_OPTION.F_GET_OPTION(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_KEY, :PI_V_NAME, :PI_V_SUBNAME); END;");

            #endregion

            #region Function Define(Except DB inline Function)_Stand

            //F_SET_EQUIP : 0 [Success] / 1 [Fail] / 4 [Duplicate]
            Table.Add(@"PKG_STAND.F_SET_EQUIP",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_SET_EQUIP(:PO_V_ERR, " +
                @":PI_V_EQUIP_ID, :PI_V_EQUIP_MODEL, :PI_V_EQUIP_VERSION, :PI_V_DESCRIPTION, :PI_N_STATE); END;");

            //F_SET_DEVICE : 0 [Success] / 1 [Fail] / 4 [Duplicate]
            Table.Add(@"PKG_STAND.F_SET_DEVICE",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_SET_DEVICE(:PO_V_ERR, " +
                @":PI_V_DEVICE_ID, :PI_V_DESIGN_RULE, :PI_V_DEVICE_PREFIX, :PI_V_DESCRIPTION, :PI_N_STATE); END;");

            //F_SET_STEP : 0 [Success] / 1 [Fail] / 4 [Duplicate]
            Table.Add(@"PKG_STAND.F_SET_STEP",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_SET_STEP(:PO_V_ERR, " +
                @":PI_V_STEP_ID, :PI_V_STEP_SEQ, :PI_V_MODE_TYPE, :PI_V_DESCRIPTION, :PI_N_STATE); END;");

            //F_SET_SITE : 0 [Success] / 1 [Fail] / 4 [Duplicate]
            Table.Add(@"PKG_STAND.F_SET_SITE",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_SET_SITE(:PO_V_ERR, " +
                @":PI_V_SITE_ID, :PI_V_SITE_NAME, :PI_V_DESCRIPTION, :PI_N_STATE); END;");

            //F_GET_DEVICE : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_STAND.F_GET_DEVICE",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_GET_DEVICE(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_DEVICE_ID, :PI_N_FLAG); END;");

            //F_GET_STEP : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_STAND.F_GET_STEP",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_GET_STEP(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_STEP_ID, :PI_N_FLAG); END;");

            //F_GET_SITE : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_STAND.F_GET_SITE",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_GET_SITE(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_SITE_ID, :PI_N_FLAG); END;");

            //F_GET_LOADER_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_LOADER_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_LOADER_INFO(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_LOADER_ALIASE, :PI_N_DIVISION); END;");

            //F_GET_MANAGER_LOADER_LINK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_MANAGER_LOADER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_MANAGER_LOADER_LINK(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_WORK_ITEM_MANAGER_ALIASE, :PI_V_LOADER_ALIASE, :PI_N_DIVISION); END;");

            //F_GET_DELIVERER_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_DELIVERER_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_DELIVERER_INFO(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_DELIVERER_ALIASE, :PI_N_DIVISION); END;");

            //F_GET_MANAGER_DELIVERER_LINK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_MANAGER_DELIVERER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_MANAGER_DELIVERER_LINK(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_WORK_ITEM_MANAGER_ALIASE, :PI_V_DELIVERER_ALIASE, :PI_N_DIVISION); END;");

            //F_GET_WORK_ITEM_MANAGER_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_WORK_ITEM_MANAGER_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_WORK_ITEM_MANAGER_INFO(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_WORK_ITEM_MANAGER_ALIASE, :PI_N_DIVISION); END;");

            //F_GET_RUNNER_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_RUNNER_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_RUNNER_INFO(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_RUNNER_ALIASE, :PI_N_DIVISION); END;");

            //F_GET_MANAGER_RUNNER_LINK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_MANAGER_RUNNER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_MANAGER_RUNNER_LINK(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_WORK_ITEM_MANAGER_ALIASE, :PI_V_RUNNER_ALIASE, :PI_N_DIVISION); END;");

            // F_GET_JOB_CHECKER_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_JOB_CHECKER_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_JOB_CHECKER_INFO(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_CHECKER_ALIASE, :PI_N_DIVISION); END;");

            // F_GET_CHECKER_MGR_COMM_LINK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_CHECKER_MGR_COMM_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_CHECKER_MGR_COMM_LINK(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_JOB_CHECKER_ALIASE, :PI_V_WORK_ITEM_MANAGER_ALIASE, :PI_V_COMMUNICATOR_ALIASE, :PI_N_DIVISION); END;");

            // F_GET_CONFIGURATOR_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_CONFIGURATOR_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_CONFIGURATOR_INFO(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_CONFIGURATOR_ALIASE, :PI_N_DIVISION); END;");

            //F_GET_NODE_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_NODE_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_NODE_INFO(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_NODE_ALIASE, :PI_N_DIVISION); END;");

            //F_GET_RUNNER_NODE_LINK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_RUNNER_NODE_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_RUNNER_NODE_LINK(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_RUNNER_ALIASE, :PI_V_NODE_ALIASE, :PI_N_DIVISION); END;");

            //F_SET_PKG_PROCESS_SPEC : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_PKG_PROCESS_SPEC",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_PKG_PROCESS_SPEC(:PO_V_ERR, " +
                @":PI_V_DEVICE_ID, :PI_V_EQUIP_ID, :PI_V_STEP_ID, :PI_N_DEFECT_COUNT_MAX, :PI_N_DEFECT_IMAGE_COUNT, " +
                @":PI_N_IMAGE_SIZE_X, :PI_N_IMAGE_SIZE_Y, :PI_N_TARGET_YN, :PI_V_IMAGE_TYPE, :PI_N_DISTRIBUTOR_TYPE, " +
                @":PI_V_SOLUTION_INFO_PATH, :PI_N_STATE); END;");

            //F_DEL_PKG_PROCESS_SPEC : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_DEL_PKG_PROCESS_SPEC",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_DEL_PKG_PROCESS_SPEC(:PO_V_ERR, " +
                @":PI_V_DEVICE_ID, :PI_V_EQUIP_ID, :PI_V_STEP_ID); END;");

            //F_GET_RECIPE_RUNNER_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_RECIPE_RUNNER_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_RECIPE_RUNNER_INFO(:PO_V_ERR, " +
                @":PI_V_RECIPE_ID, :PI_V_RUNNER_ALIASE, :PI_N_DIVISION); END;");

            //F_GET_RECIPE_RUNNER_LINK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_RUNNER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_RUNNER_LINK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID); END;");

            //F_GET_DIVISION : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_STAND.F_GET_DIVISION",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_GET_DIVISION(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_DIVISION); END;");

            //F_GET_ACTOR : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_STAND.F_GET_ACTOR",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_GET_ACTOR(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_ACTOR, :PI_V_DIVISION); END;");

            //F_GET_STATUS : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_STAND.F_GET_STATUS",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_GET_STATUS(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_STATUS, :PI_V_DIVISION); END;");

            //F_GET_JUDGE_CODE : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_STAND.F_GET_JUDGE_CODE",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_GET_JUDGE_CODE(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_ACTOR, :PI_V_STATUS, :PI_V_DIVISION); END;");

            //F_GET_ERROR_CODE : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_STAND.F_GET_ERROR_CODE",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_GET_ERROR_CODE(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_ACTOR, :PI_V_STATUS, :PI_V_DIVISION); END;");

            //F_GET_WARNING_CODE : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_STAND.F_GET_WARNING_CODE",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_GET_WARNING_CODE(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_ACTOR, :PI_V_STATUS, :PI_V_DIVISION); END;");

            //F_SET_ERROR_CODE : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_STAND.F_SET_ERROR_CODE",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_SET_ERROR_CODE(:PO_V_ERR, " +
                @":PI_V_ERROR_CODE, :PI_N_CODE_NUM, :PI_V_CODE_FULL, :PI_V_ACTOR, :PI_V_STATUS, :PI_V_DIVISION, " +
                @":PI_V_DESCRIPTION, :PI_N_STATE); END;");

            //F_SET_WARNING_CODE : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_STAND.F_SET_WARNING_CODE",
                @"BEGIN :PO_I_RETURN:=PKG_STAND.F_SET_WARNING_CODE(:PO_V_ERR, " +
                @":PI_V_WARNING_CODE, :PI_N_CODE_NUM, :PI_V_CODE_FULL, :PI_V_ACTOR, :PI_V_STATUS, :PI_V_DIVISION, " +
                @":PI_V_DESCRIPTION, :PI_N_STATE); END;");

            //F_SET_WORK_ITEM_MANAGER : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_WORK_ITEM_MANAGER",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_WORK_ITEM_MANAGER(:PO_V_ERR, " +
                @":PI_V_MANAGER_ALIASE, :PI_V_MANAGER_IP, :PI_V_MANAGER_PORT, :PI_V_MANAGER_USER, :PI_V_MANAGER_PW, " +
                @":PI_V_MONITORING_PATH, :PI_V_MONITORING_FILE_CODE, :PI_N_MONITORING_INTERVAL, :PI_N_WORKFLOW_COUNT, " +
                @":PI_V_RELATIVE_PATH_EXE, :PI_N_PROCESS_LIMIT_TIME, :PI_N_DIVISION, :PI_CL_SETUP_DATA, :PI_N_STATE); END;");

            //F_SET_LOADER : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_LOADER",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_LOADER(:PO_V_ERR, " +
                @":PI_V_LOADER_ALIASE, :PI_V_LOADER_IP, :PI_V_LOADER_PORT, :PI_V_LOADER_USER, :PI_V_LOADER_PW, " +
                @":PI_V_MONITORING_PATH, :PI_V_MONITORING_FILE_CODE, :PI_N_MONITORING_INTERVAL, :PI_N_WORKFLOW_COUNT, " +
                @":PI_V_RELATIVE_PATH_EXE, :PI_N_PROCESS_LIMIT_TIME, :PI_N_DIVISION, :PI_CL_SETUP_DATA, :PI_N_STATE); END;");

            //F_SET_MANAGER_LOADER_LINK : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_MANAGER_LOADER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_MANAGER_LOADER_LINK(:PO_V_ERR, " +
                @":PI_V_MANAGER_ALIASE, :PI_V_LOADER_ALIASE); END;");

            //F_SET_RUNNER : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_RUNNER",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_RUNNER(:PO_V_ERR, " +
                @":PI_V_RUNNER_ALIASE, :PI_V_RUNNER_IP, :PI_V_RUNNER_PORT, :PI_V_RUNNER_USER, :PI_V_RUNNER_PW, " +
                @":PI_V_MONITORING_PATH, :PI_V_MONITORING_FILE_CODE, :PI_N_MONITORING_INTERVAL, :PI_N_WORKFLOW_COUNT, " +
                @":PI_V_RELATIVE_PATH_EXE, :PI_N_PROCESS_LIMIT_TIME, :PI_N_DIVISION, :PI_CL_SETUP_DATA, :PI_N_STATE); END;");

            //F_SET_MANAGER_RUNNER_LINK : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_MANAGER_RUNNER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_MANAGER_RUNNER_LINK(:PO_V_ERR, " +
                @":PI_V_MANAGER_ALIASE, :PI_V_RUNNER_ALIASE); END;");

            //F_SET_NODE : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_NODE",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_NODE(:PO_V_ERR, " +
                @":PI_V_NODE_ALIASE, :PI_CL_SETUP_DATA, :PI_N_STATE); END;");

            //F_SET_RUNNER_NODE_LINK : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_RUNNER_NODE_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_RUNNER_NODE_LINK(:PO_V_ERR, " +
                @":PI_V_RUNNER_ALIASE, :PI_V_NODE_ALIASE); END;");

            //F_SET_RECIPE_RUNNER_LINK : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_RECIPE_RUNNER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_RECIPE_RUNNER_LINK(:PO_V_ERR, " +
                @":PI_N_RECIPE_ID, :PI_V_RUNNER_ALIASE); END;");

            //F_SET_DELIVERER : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_DELIVERER",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_DELIVERER(:PO_V_ERR, " +
                @":PI_V_DELIVERER_ALIASE, :PI_V_DELIVERER_IP, :PI_V_DELIVERER_PORT, :PI_V_DELIVERER_USER, :PI_V_DELIVERER_PW, " +
                @":PI_V_MONITORING_PATH, :PI_V_MONITORING_FILE_CODE, :PI_N_MONITORING_INTERVAL, :PI_N_WORKFLOW_COUNT, " +
                @":PI_V_RELATIVE_PATH_EXE, :PI_N_PROCESS_LIMIT_TIME, :PI_N_DIVISION, :PI_CL_SETUP_DATA, :PI_N_STATE); END;");

            //F_SET_MANAGER_DELIVERER_LINK : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_MANAGER_DELIVERER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_MANAGER_DELIVERER_LINK(:PO_V_ERR, " +
                @":PI_V_MANAGER_ALIASE, :PI_V_DELIVERER_ALIASE); END;");

            // F_GET_COMMUNICATOR_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_COMMUNICATOR_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_COMMUNICATOR_INFO(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_COMM_ALIASE, :PI_N_DIVISION); END;");

            // F_GET_COMM_LOADER_LINK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_COMM_LOADER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_COMM_LOADER_LINK(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_COMM_ALIASE, :PI_V_LOADER_ALIASE, :PI_N_DIVISION); END;");

            // F_GET_COMM_DELIVERER_LINK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SYS_PROCESS.F_GET_COMM_DELIVERER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_GET_COMM_DELIVERER_LINK(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_COMM_ALIASE, :PI_V_DELIVERER_ALIASE, :PI_N_DIVISION); END;");

            // F_SET_COMMUNICATOR : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_COMMUNICATOR",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_COMMUNICATOR(:PO_V_ERR, " +
                @":PI_V_COMM_ALIASE, :PI_V_COMM_IP, :PI_V_COMM_PORT, :PI_V_COMM_USER, :PI_V_COMM_PW, " +
                @":PI_V_MONITORING_PATH, :PI_V_MONITORING_FILE_CODE, :PI_N_MONITORING_INTERVAL, :PI_N_WORKFLOW_COUNT, " +
                @":PI_V_RELATIVE_PATH_EXE, :PI_N_PROCESS_LIMIT_TIME, :PI_N_DIVISION, :PI_CL_SETUP_DATA, :PI_N_STATE); END;");

            // F_SET_COMM_LOADER_LINK : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_COMM_LOADER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_COMM_LOADER_LINK(:PO_V_ERR, " +
                @":PI_V_COMM_ALIASE, :PI_V_LOADER_ALIASE); END;");

            // F_SET_COMM_DELIVERER_LINK : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SYS_PROCESS.F_SET_COMM_DELIVERER_LINK",
                @"BEGIN :PO_I_RETURN:=PKG_SYS_PROCESS.F_SET_COMM_DELIVERER_LINK(:PO_V_ERR, " +
                @":PI_V_COMM_ALIASE, :PI_V_DELIVERER_ALIASE); END;");

            #endregion

            #region Function Define(Except DB inline Function)_Recipe

            //F_SET_RECIPE_CONFIGURE : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_RECIPE.F_SET_RECIPE_CONFIGURE",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_SET_RECIPE_CONFIGURE(:PO_V_ERR, " +
                @":PI_V_DEVICE_ID, :PI_V_STEP_ID, :PI_V_SITE_ID, :PI_V_EQUIP_ID, :PI_V_RECIPE_ID, :PI_V_WRITE_USER, " +
                @":PI_N_STATE); END;");

            //F_GET_RECIPE_CONFIGURE : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_CONFIGURE",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_CONFIGURE(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_DEVICE_ID, :PI_V_STEP_ID, :PI_V_SITE_ID, :PI_V_EQUIP_ID); END;");

            //F_GET_RECIPE_CONFIGURE_APP : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_CONFIGURE_APP",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_CONFIGURE_APP(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_DEVICE_ID, :PI_V_STEP_ID, :PI_V_SITE_ID, :PI_V_EQUIP_ID); END;");

            //F_GET_RECIPE : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID, :PI_N_RECIPE_PID, :PI_V_RECIPE_NAME); END;");

            //F_GET_RECIPE_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_SET_RECIPE : 0 [Success] / 1 [Fail] / 3 [ERR_NOT_EXIST]  / 4 [Duplicate]  / 5 [ERR_TOO_MANY_ROWS]
            Table.Add(@"PKG_RECIPE.F_SET_RECIPE",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_SET_RECIPE(:PO_V_ERR, :PO_N_RECIPE_ID, :PO_N_RECIPE_PID," +
                @":PI_N_RECIPE_ID, :PI_N_RECIPE_PID, :PI_V_RECIPE_NAME, :PI_V_REVISION_VERSION, :PI_V_STORAGE_PATH, " +
                @":PI_N_USE_YN, :PI_N_LOCKING, :PI_V_REG_IP, :PI_CL_MODEL_PARAMETERS, :PI_CL_FIT_PARAMETERS, " +
                @":PI_CL_META_PARAMETERS, :PI_CL_REPORTING_PARAMETERS, :PI_CL_VALUE_PARAMETERS, :PI_CL_CONDITIONS, " +
                @":PI_CL_STRUCTURE, :PI_CL_INPUT_YAML, :PI_CL_RECIPE_TOTAL_DATA, :PI_V_KERNEL_TYPE, :PI_V_SPECTRUM_TYPE, " +
                @":PI_V_MEASURE_TYPE, :PI_N_STATE, :PI_V_SOL_ID, :PI_V_SOL_PID ); END;");

            //F_GET_RECIPE_MODEL_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_MODEL_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_MODEL_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_GET_RECIPE_FIT_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_FIT_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_FIT_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_GET_RECIPE_META_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_META_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_META_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_GET_RECIPE_REPORTING_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_REPORTING_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_REPORTING_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_GET_RECIPE_VALUE_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_VALUE_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_VALUE_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_GET_RECIPE_CONDITIONS_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_CONDITIONS_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_CONDITIONS_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_GET_RECIPE_STRUCTURE_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_STRUCTURE_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_STRUCTURE_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_GET_RECIPE_INPUT_YAML_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_INPUT_YAML_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_INPUT_YAML_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_GET_RECIPE_TOTAL_DATA_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_TOTAL_DATA_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_TOTAL_DATA_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_GET_RECIPE_MEASURE_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_MEASURE_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_MEASURE_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_RECIPE_ID); END;");

            //F_GET_RECIPE_ENGINE : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_RECIPE.F_GET_RECIPE_ENGINE",
                @"BEGIN :PO_I_RETURN:=PKG_RECIPE.F_GET_RECIPE_ENGINE(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_JOB_ID, :PI_V_WAFER_ID, :PI_N_POINT_ID); END;");

            #endregion

            #region Function Define(Except DB inline Function)_SOLUTION

            //F_SET_MODEL_INFO : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SOLUTION.F_SET_MODEL_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_SET_MODEL_INFO(:PO_V_ERR, " +
                @":PI_V_NAME, :PI_V_STORAGE_PATH, :PI_V_DATE, :PI_N_USE_YN, :PI_CL_BLOCK_DATA, :PI_V_DESCRIPTION, " +
                @":PI_V_WRITE_USER, :PI_N_STATE); END;");

            //F_SET_FIT_INFO : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SOLUTION.F_SET_FIT_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_SET_FIT_INFO(:PO_V_ERR, " +
                @":PI_V_NAME, :PI_V_STORAGE_PATH, :PI_V_DATE, :PI_N_USE_YN, :PI_CL_BLOCK_DATA, :PI_V_DESCRIPTION, " +
                @":PI_V_WRITE_USER, :PI_N_STATE); END;");

            //F_SET_META_INFO : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SOLUTION.F_SET_META_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_SET_META_INFO(:PO_V_ERR, " +
                @":PI_V_NAME, :PI_V_STORAGE_PATH, :PI_V_DATE, :PI_N_USE_YN, :PI_CL_BLOCK_DATA, :PI_V_DESCRIPTION, " +
                @":PI_V_WRITE_USER, :PI_N_STATE); END;");

            //F_SET_REPORTING_INFO : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SOLUTION.F_SET_REPORTING_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_SET_REPORTING_INFO(:PO_V_ERR, " +
                @":PI_V_NAME, :PI_V_STORAGE_PATH, :PI_V_DATE, :PI_N_USE_YN, :PI_CL_BLOCK_DATA, :PI_V_DESCRIPTION, " +
                @":PI_V_WRITE_USER, :PI_N_STATE); END;");

            //F_SET_VALUE_INFO : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SOLUTION.F_SET_VALUE_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_SET_VALUE_INFO(:PO_V_ERR, " +
                @":PI_V_NAME, :PI_V_STORAGE_PATH, :PI_V_DATE, :PI_N_USE_YN, :PI_CL_BLOCK_DATA, :PI_V_DESCRIPTION, " +
                @":PI_V_WRITE_USER, :PI_N_STATE); END;");

            //F_SET_CONDITION_INFO : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SOLUTION.F_SET_CONDITION_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_SET_CONDITION_INFO(:PO_V_ERR, " +
                @":PI_V_NAME, :PI_V_STORAGE_PATH, :PI_V_DATE, :PI_N_USE_YN, :PI_CL_BLOCK_DATA, :PI_V_DESCRIPTION, " +
                @":PI_V_WRITE_USER, :PI_N_STATE); END;");

            //F_SET_STRUCTURE_INFO : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SOLUTION.F_SET_STRUCTURE_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_SET_STRUCTURE_INFO(:PO_V_ERR, " +
                @":PI_V_NAME, :PI_V_STORAGE_PATH, :PI_V_DATE, :PI_N_USE_YN, :PI_CL_BLOCK_DATA, :PI_V_DESCRIPTION, " +
                @":PI_V_WRITE_USER, :PI_N_STATE); END;");

            //F_SET_YAML_INFO : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SOLUTION.F_SET_YAML_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_SET_YAML_INFO(:PO_V_ERR, " +
                @":PI_V_NAME, :PI_V_STORAGE_PATH, :PI_V_DATE, :PI_N_USE_YN, :PI_CL_BLOCK_DATA, :PI_V_DESCRIPTION, " +
                @":PI_V_WRITE_USER, :PI_N_STATE); END;");

            //F_SET_SOLUTION_INFO : 0 [Success] / 1 [Fail] / 4 [Duplicate] 
            Table.Add(@"PKG_SOLUTION.F_SET_SOLUTION_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_SET_SOLUTION_INFO(:PO_V_ERR, " +
                @":PI_ID, :PI_PID, :PI_V_NAME, :PI_V_VERSION, :PI_V_DATE, :PI_V_WRITE_USER, " +
                @":PI_N_SEQ_ID_MODEL, :PI_N_SEQ_ID_FIT, :PI_N_SEQ_ID_META, :PI_N_SEQ_ID_REPORTING, :PI_N_SEQ_ID_VALUE, " +
                @":PI_N_SEQ_ID_CONDITION, :PI_N_SEQ_ID_STRUCTURE, :PI_N_SEQ_ID_YAML, :PI_N_SEQ_ID_MATERIAL, :PI_CL_TOTAL_DATA, :PI_V_STORAGE_PATH, " +
                @":PI_N_STATE, :PI_N_DATA_MAKE_TYPE_FLAG); END;");

            //F_GET_SOLUTION_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SOLUTION.F_GET_SOLUTION_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_GET_SOLUTION_INFO(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_START_DATE, :PI_V_END_DATE, :PI_V_NAME); END;");

            //F_DEL_SOLUTION_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SOLUTION.F_DEL_SOLUTION_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_DEL_SOLUTION_INFO(:PO_V_ERR, " +
                @":PI_N_SOL_ID, :PI_N_SOL_PID); END;");

            //F_GET_SOLUTION_BLOCK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_SOLUTION.F_GET_SOLUTION_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_SOLUTION.F_GET_SOLUTION_BLOCK(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_SOL_ID, :PI_N_SOL_PID); END;");

            #endregion

            #region Function Define(Except DB inline Function)_DELIVER

            // F_GET_RESULT_WORK_ITEM : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_DATA_DELIVER.F_GET_RESULT_WORK_ITEM",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_DELIVER.F_GET_RESULT_WORK_ITEM(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_WORK_ITEM_ID); END;");

            // F_MODIFY_RESULT_DATA_BLOCK : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_DATA_DELIVER.F_MODIFY_RESULT_DATA_BLOCK",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_DELIVER.F_MODIFY_RESULT_DATA_BLOCK(:PO_V_ERR, " +
                @":PI_V_RESULT_TYPE, :PI_V_WORK_ITEM_ID, :PI_V_RESULT_ITEM_ID, :PI_CL_FIT_RESULT_DATA); END;");

            #endregion

            #region get Rendezvous data (For Communicator)

            // F_GET_RV_MSG_BLOCK_IDBS : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_DATA_DELIVER.F_GET_RV_MSG_BLOCK_IDBS",
                @"BEGIN :PO_I_RETURN:=PKG_DATA_DELIVER.F_GET_RV_MSG_BLOCK_IDBS(:PO_V_ERR, :PO_CUR, " +
                @":PI_N_JOB_ID); END;");

            #endregion

            #region Function Define(Except DB inline Function)_Monitor

            //F_SET_SYSTEM_STATUS : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_MONITOR.F_SET_SYSTEM_STATUS",
                @"BEGIN :PO_I_RETURN:=PKG_MONITOR.F_SET_SYSTEM_STATUS(:PO_V_ERR, " +
                @":PI_V_GROUP_ALIASE, :PI_V_ACTOR, :PI_V_ACTOR_ALIASE, " +
                @":PI_N_CPU_TOTAL, :PI_N_CPU_USED, :PI_V_CPU_UNIT, " +
                @":PI_N_MEMORY_TOTAL, :PI_N_MEMORY_USED, :PI_V_MEMORY_UNIT, " +
                @":PI_V_NETWORK_IP, :PI_V_NETWORK_TYPE, :PI_N_NETWORK_USED_RATIO, :PI_V_NETWORK_UNIT, " +
                @":PI_V_OS, :PI_CL_OTHER_DATA_BLOCK); END;");

            //F_GET_SYSTEM_STATUS : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_MONITOR.F_GET_SYSTEM_STATUS",
                @"BEGIN :PO_I_RETURN:=PKG_MONITOR.F_GET_SYSTEM_STATUS(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_GROUP_ALIASE, :PI_V_ACTOR, :PI_V_ACTOR_ALIASE); END;");

            //F_DEL_SYSTEM_STATUS : 0 [Success] / 1 [Fail] 
            Table.Add(@"PKG_MONITOR.F_DEL_SYSTEM_STATUS",
                @"BEGIN :PO_I_RETURN:=PKG_MONITOR.F_DEL_SYSTEM_STATUS(:PO_V_ERR, " +
                @":PI_V_GROUP_ALIASE); END;");

            //F_SET_MONITOR_CONDITION : 0 [Success] / 1 [Fail] / 4 [중복데이터]
            Table.Add(@"PKG_MONITOR.F_SET_MONITOR_CONDITION",
                @"BEGIN :PO_I_RETURN:=PKG_MONITOR.F_SET_MONITOR_CONDITION(:PO_V_ERR, " +
                @":PI_V_GROUP_ALIASE, :PI_V_ACTOR, :PI_V_USER_ID, " +
                @":PI_CL_CONDITION_DATA_BLOCK, :PI_N_STATE); END;");

            //F_GET_MONITOR_CONDITION : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_MONITOR.F_GET_MONITOR_CONDITION",
                @"BEGIN :PO_I_RETURN:=PKG_MONITOR.F_GET_MONITOR_CONDITION(:PO_V_ERR, :PO_CUR, " +
                @":PI_V_GROUP_ALIASE, :PI_V_ACTOR); END;");

            //F_DEL_MONITOR_CONDITION : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_MONITOR.F_DEL_MONITOR_CONDITION",
                @"BEGIN :PO_I_RETURN:=PKG_MONITOR.F_DEL_MONITOR_CONDITION(:PO_V_ERR, " +
                @":PI_V_GROUP_ALIASE, :PI_V_ACTOR); END;");

            #endregion

            #region Function Define(Offline Function) _JobManager
            //F_GET_JOB_PROCESS_INFO : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_INFO(:PO_V_ERR,:PO_CUR, " +
                @":PI_DA_START_DATE, :PI_DA_END_DATE); END;");

            //F_GET_JOB_PROCESS_HIS : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_HIS",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_HIS(:PO_V_ERR,:PO_CUR, " +
                @":PI_DA_START_DATE, :PI_DA_END_DATE, :PI_SOL_ID, :PI_SOL_PID); END;");

            //F_GET_JOB_PROCESS_QUICK : 0 [Success] / 1 [Fail]
            Table.Add(@"PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_QUICK",
                @"BEGIN :PO_I_RETURN:=PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_QUICK(:PO_V_ERR,:PO_CUR, " +
                @":PI_DA_START_DATE, :PI_DA_END_DATE, :PI_V_WORK_ITEM_MANAGER_ALIASE); END;");

            //F_SET_JOB_OFFLINE : 0 [Success] / 1 [Fail] / 5 [ERR_TOO_MANY_ROWS] 
            Table.Add(@"PKG_JOB.F_SET_JOB_OFFLINE",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_SET_JOB_OFFLINE(:PO_V_ERR, :PO_N_JOB_ID, " +
                @":PI_V_START_DATE, :PI_N_PROCESS_LIMIT_TIME, :PI_V_CURRENT_MODULE, :PI_N_WAFER_CNT_TOTAL, " +
                @":PI_N_WAFER_CNT_MISSING, :PI_V_STORAGE_IMAGE_PATH, :PI_N_PROCESS_PERCENT, :PI_V_STORAGE_RESULT_PATH, " +
                @":PI_CL_RV_MSG_DATA, :PI_V_JOB_KIND, :PI_V_JOB_TYPE, :PI_V_JOB_NAME); END;");
            #endregion

            #region Function Define(Offline Function) _Job

            Table.Add(@"PKG_JOB.F_CHECK_JOB_RESULT_INFO",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_CHECK_JOB_RESULT_INFO(:PO_V_ERR,:PO_N_CNT," +
                @":PI_N_JOB_ID); END;");

            Table.Add(@"PKG_JOB.F_DEL_JOB_DATA_VIRTUAL",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_DEL_JOB_DATA_VIRTUAL(:PO_V_ERR," +
                @":PI_N_JOB_ID); END;");

            Table.Add(@"PKG_JOB.F_SET_JOB_RESTART_INIT",
                @"BEGIN :PO_I_RETURN:=PKG_JOB.F_SET_JOB_RESTART_INIT(:PO_V_ERR," +
                @":PI_N_JOB_ID); END;");
            #endregion

            #region Function Define(offline Function) _Stand Exist
            Table.Add(@"PKG_STAND.F_EXIST_DEVICE",
                        @"BEGIN :PO_I_RETURN:=PKG_STAND.F_EXIST_DEVICE(:PO_V_ERR," +
                        @":PO_N_CNT, :PI_V_DEVICE_ID); END;");

            Table.Add(@"PKG_STAND.F_EXIST_STEP",
                        @"BEGIN :PO_I_RETURN:=PKG_STAND.F_EXIST_STEP(:PO_V_ERR," +
                        @":PO_N_CNT, :PI_V_STEP_ID); END;");

            Table.Add(@"PKG_STAND.F_EXIST_EQUIP",
                        @"BEGIN :PO_I_RETURN:=PKG_STAND.F_EXIST_EQUIP(:PO_V_ERR," +
                        @":PO_N_CNT, :PI_V_EQUIP_ID); END;");


            #endregion

            #region etc
            // UpdateStatus
            Table.Add(@"UpdateStatus", @"UpdateStatus");
            #endregion
        }
    }
}
