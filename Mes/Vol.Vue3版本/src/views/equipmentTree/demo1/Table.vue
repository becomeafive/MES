<!--
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/equipment/Equipment.js此处编写
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
    import extend from "@/views/equipmentTree/demo1/table.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'ID',
                footer: "Foots",
                cnName: '设备台账',
                name: 'equipment/Equipment',
                url: "/Equipment/",
                sortName: "ID"
            });
            const editFormFields = ref({"EquipmentNo":"","EquipmentName":"","LineID":"","StationID":""});
            const editFormOptions = ref([[{"title":"设备编号","required":true,"field":"EquipmentNo"},
                               {"title":"设备名称","required":true,"field":"EquipmentName"}],
                              [{"dataKey":"线体下拉","data":[],"title":"产线名称","required":true,"field":"LineID","type":"select"},
                               {"dataKey":"工位下拉","data":[],"title":"工位名称","required":true,"field":"StationID","type":"select"}]]);
            const searchFormFields = ref({"EquipmentNo":"","EquipmentName":""});
            const searchFormOptions = ref([[{"title":"设备编号","field":"EquipmentNo","type":"like"},{"title":"设备名称","field":"EquipmentName","type":"like"}]]);
            const columns = ref([{field:'ID',title:'ID',type:'int',width:110,hidden:true,require:true,align:'left'},
                       {field:'EquipmentNo',title:'设备编号',type:'string',width:110,require:true,align:'left',sort:true},
                       {field:'EquipmentName',title:'设备名称',type:'string',width:120,require:true,align:'left'},
                       {field:'LineID',title:'产线名称',type:'int',bind:{ key:'线体下拉',data:[]},width:110,require:true,align:'left'},
                       {field:'StationID',title:'工位名称',type:'int',bind:{ key:'工位下拉',data:[]},width:110,require:true,align:'left'},
                       {field:'LineID',title:'产线名称',type:'int',bind:{ key:'线体下拉',data:[]},width:110,hidden:true,require:true,align:'left'},
                       {field:'StationID',title:'工位名称',type:'int',bind:{ key:'工位下拉',data:[]},width:110,hidden:true,require:true,align:'left'},
                       {field:'LastUpTime',title:'最后一次维修时间',type:'datetime',width:110,align:'left',sort:true},
                       {field:'LastUpOperator',title:'最后一次维修人员',type:'string',width:110,align:'left'}]);
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
