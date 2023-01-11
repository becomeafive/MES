<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/productinfo/ProductInfo.js此处编写
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
    import extend from "@/extension/business/productinfo/ProductInfo.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '产品信息',
                name: 'productinfo/ProductInfo',
                url: "/ProductInfo/",
                sortName: "ID"
            });
            const editFormFields = ref({"ProductType":"","ProductName":""});
            const editFormOptions = ref([[{"title":"产品型号","field":"ProductType"},
                               {"title":"产品描述","field":"ProductName"}]]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ProductType',title:'产品型号',type:'string',width:110,align:'left',sort:true},
                       {field:'ProductName',title:'产品描述',type:'string',width:110,align:'left'}]);
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
