<template>
	<v-jsoneditor
		v-model="paramaters"
		:options="options"
		:plus="false"
		height="400px"
		@error="onError"
	>
	</v-jsoneditor>
</template>

<script>
	import VJsoneditor from 'v-jsoneditor/src/index'

	export default {
		name: 'app',
		props: {
			paramaters: {
				type: Object,
				required: true,
			},
		},
		components: {
			VJsoneditor,
		},
		data() {
			return {
				options: {
					mode: 'code',
				},
			}
		},
		methods: {
			onError() {
				console.log('error')
			},
		},
	}
</script>
