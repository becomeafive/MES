/*****************************************************************************************
**完整文档见：http://v2.volcore.xyz/document/api 【代码生成页面ViewGrid】
**常用示例见：http://v2.volcore.xyz/document/vueDev
**后台操作见：http://v2.volcore.xyz/document/netCoreDev
*****************************************************************************************/
//此js文件是用来自定义扩展业务代码，可以扩展一些自定义页面或者重新配置生成的代码
import { h, resolveComponent } from 'vue';
import gridHeader from "./SellOrderComponents/GridHeaderExtend.vue"

let extension = {
  components: {
    gridHeader:gridHeader,
    //查询界面扩展组件
    gridBody: '',
    gridFooter: '',
    //新建、编辑弹出框扩展组件
    modelHeader: '',
    modelBody: '',
    modelFooter: ''
  },
  tableAction: '', //指定某张表的权限(这里填写表名,默认不用填写)
  buttons: { view: [
    {
      name: "切换多选单选",
      icon: 'md-create',
      value: 'OpenCheckbox',
      class: '',
      type: 'primary',
      index: 1,//显示的位置
      onClick: function () { //扩展按钮执行事件
        //this可以获取所有属性，包括this.$refs.gridHeader/gridBody等获取扩展组件对象
        // this.$message("测试扩展按钮");
        if(this.single){
          this.$message("开启多选");
          this.single = false;
        }else{
          this.$message("关闭多选");
          this.single = true;
          //load();
          //resizeTo();
        }
      }
    }
  ], box: [], detail: [] }, //扩展的按钮
  methods: {
    btn1Click(row, $e) {
      // $e.stopPropagation();
      this.$refs.gridHeader.open(row);

    },
     //下面这些方法可以保留也可以删除
    onInit() {  //框架初始化配置前，
        //示例：在按钮的最前面添加一个按钮
        //   this.buttons.unshift({  //也可以用push或者splice方法来修改buttons数组
        //     name: '按钮', //按钮名称
        //     icon: 'el-icon-document', //按钮图标vue2版本见iview文档icon，vue3版本见element ui文档icon(注意不是element puls文档)
        //     type: 'primary', //按钮样式vue2版本见iview文档button，vue3版本见element ui文档button
        //     onClick: function () {
        //       this.$Message.success('点击了按钮');
        //     }
        //   });

        this.single = true;
        
      //表格上添加自定义按钮
      this.columns.push({
        title: "操作",
        field: "操作",
        width: 150,
        align: "center",
        render: (h, { row, column, index }) => {
          return <div >
            <el-button onClick={($e) => { this.btn1Click(row, $e) }} type="primary" plain size="small" style="padding: 10px !important;">查看</el-button>
          </div>
        }
      })
        this.boxOptions.height = document.documentElement.clientHeight * 0.6;
        //示例：设置修改新建、编辑弹出框字段标签的长度
        // this.boxOptions.labelWidth = 150;
        this.editFormOptions.forEach(x => {
          x.forEach(item => {
            if (item.field == 'Path') {
              item.type = 'file';//可以指定上传文件类型img/file/excel
              //设置上传图片字段100%宽度
              item.colSize = 12;
              //启用多图上传(默认单图)
              item.multiple = false;
              //禁止自动上传(默认自动上传)
              item.autoUpload=true;
              //最多可以上传3张照片
              item.maxFile = 1;
              //限制图片大小，默认3M
              item.maxSize = 3;
              //选择文件时
              item.onChange=(files)=>{
                 console.log('选择文件事件')
                 //此处不返回true，会中断代码执行
                 return true;
              }
              //上传前
              item.uploadBefore=(files)=>{
                console.log('上传前')
                return true;
              }
               //上传后
               item.uploadAfter=(files)=>{
                console.log('上传后')
                return true;
              }
            }
          })
        })
    },
    onInited() {
      //框架初始化配置后
      //如果要配置明细表,在此方法操作
      //this.detailOptions.columns.forEach(column=>{ });
    },
    searchBefore(param) {
      //界面查询前,可以给param.wheres添加查询参数
      //返回false，则不会执行查询
      return true;
    },
    searchAfter(result) {
      //查询后，result返回的查询数据,可以在显示到表格前处理表格的值
      return true;
    },
    addBefore(formData) {
      //新建保存前formData为对象，包括明细表，可以给给表单设置值，自己输出看formData的值
      return true;
    },
    updateBefore(formData) {
      //编辑保存前formData为对象，包括明细表、删除行的Id
      return true;
    },
    rowClick({ row, column, event }) {
      //查询界面点击行事件
      // this.$refs.table.$refs.table.toggleRowSelection(row); //单击行时选中当前行;
    },
    modelOpenAfter(row) {
      //点击编辑、新建按钮弹出框后，可以在此处写逻辑，如，从后台获取数据
      //(1)判断是编辑还是新建操作： this.currentAction=='Add';
      //(2)给弹出框设置默认值
      //(3)this.editFormFields.字段='xxx';
      //如果需要给下拉框设置默认值，请遍历this.editFormOptions找到字段配置对应data属性的key值
      //看不懂就把输出看：console.log(this.editFormOptions)
    }
  }
};
export default extension;
