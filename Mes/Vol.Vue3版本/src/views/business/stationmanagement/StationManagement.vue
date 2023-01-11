<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/stationmanagement/StationManagement.js此处编写
 -->
<template>
    <view-grid ref="grid"
               :columns="columns"
               :detail="detail"
               :editFormFields="editFormFields"
               :editFormOptions="editFormOptions"
               :searchFormFields="searchFormFields"
               :searchFormOptions="searchFormOptions"
               :table="table"
               :extend="extend">
    </view-grid>
</template>
<script>
    import extend from "@/extension/business/stationmanagement/StationManagement.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '工位管理',
                name: 'stationmanagement/StationManagement',
                url: "/StationManagement/",
                sortName: "ID"
            });
            const editFormFields = ref({"StaionName":"","LineID":"","StationOrder":"","IP":"","StationRemark":""});
            const editFormOptions = ref([[{"dataKey":"线体下拉","data":[],"title":"产线名称","required":true,"field":"LineID","type":"select"},
                               {"title":"工位编号","field":"StaionName"}],
                              [{"title":"工位IP","field":"IP"},
                               {"title":"工位排序","field":"StationOrder","type":"number"}],
                              [{"title":"工位备注","field":"StationRemark","type":"textarea"}]]);
            const searchFormFields = ref({"StaionName":"","LineID":""});
            const searchFormOptions = ref([[{"dataKey":"线体下拉","data":[],"title":"产线名称","field":"LineID","type":"select"},{"title":"工位编号","field":"StaionName","type":"like"}]]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,require:true,align:'left'},
                       {field:'StaionName',title:'工位编号',type:'string',width:110,align:'left',sort:true},
                       {field:'LineID',title:'产线名称',type:'int',bind:{ key:'线体下拉',data:[]},width:110,require:true,align:'left'},
                       {field:'StationRemark',title:'工位备注',type:'string',width:180,align:'left'},
                       {field:'StationOrder',title:'工位排序',type:'int',width:80,align:'left'},
                       {field:'IP',title:'工位IP',type:'string',width:110,align:'left'}]);
            const detail = ref({
                cnName: "#detailCnName",
                table: "#detailTable",
                columns: [],
                sortName: "",
                key: ""
            });
            return {
                table,
                extend,
                editFormFields,
                editFormOptions,
                searchFormFields,
                searchFormOptions,
                columns,
                detail,
            };
        },
    });
</script>
