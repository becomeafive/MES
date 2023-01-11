<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/productvesion/ProductVesion.js此处编写
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
    import extend from "@/extension/business/productvesion/ProductVesion.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '产品配方',
                name: 'productvesion/ProductVesion',
                url: "/ProductVesion/",
                sortName: "ID"
            });
            const editFormFields = ref({"VersionCode":"","ProductID":""});
            const editFormOptions = ref([[{"title":"配方版本号","field":"VersionCode","type":"text"},
                               {"title":"产品型号","field":"ProductID","type":"text"}]]);
            const searchFormFields = ref({"ProductID":""});
            const searchFormOptions = ref([[{"title":"产品型号","field":"ProductID","type":"text"}]]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'VersionCode',title:'配方版本号',type:'string',width:110,align:'left',sort:true},
                       {field:'ProductID',title:'产品型号',type:'int',width:110,align:'left'},
                       {field:'CreateTime',title:'创建时间',type:'datetime',width:110,align:'left',sort:true}]);
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
