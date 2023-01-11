<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/stationinfo/StationInfo.js此处编写
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
    import extend from "@/extension/business/stationinfo/StationInfo.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '工艺路线',
                name: 'stationinfo/StationInfo',
                url: "/StationInfo/",
                sortName: "ID"
            });
            const editFormFields = ref({"LineID":"","StationID":"","ProductID":"","XOrder":"","Remark":""});
            const editFormOptions = ref([[{"dataKey":"线体下拉","data":[],"title":"线体","field":"LineID","type":"select"},
                               {"dataKey":"工位下拉","data":[],"title":"工位","field":"StationID","type":"select"}],
                              [{"dataKey":"产品下拉","data":[],"title":"产品","field":"ProductID","type":"select"},
                               {"title":"排序","field":"XOrder","type":"number"}],
                              [{"title":"备注","field":"Remark","type":"textarea"}]]);
            const searchFormFields = ref({"LineID":"","ProductID":""});
            const searchFormOptions = ref([[{"dataKey":"线体下拉","data":[],"title":"线体","field":"LineID","type":"select"},{"dataKey":"产品下拉","data":[],"title":"产品","field":"ProductID","type":"select"}]]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'LineID',title:'线体',type:'int',bind:{ key:'线体下拉',data:[]},width:110,align:'left',sort:true},
                       {field:'StationID',title:'工位',type:'int',bind:{ key:'工位下拉',data:[]},width:110,align:'left'},
                       {field:'ProductID',title:'产品',type:'int',bind:{ key:'产品下拉',data:[]},width:110,align:'left'},
                       {field:'XOrder',title:'排序',type:'int',sort:true,width:110,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:180,align:'left'},
                       {field:'VersionNumber',title:'VersionNumber',type:'string',width:110,hidden:true,align:'left'}]);
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
