<template>
	<v-row align="center" justify="center">
		<v-col cols="12">
			<v-card>
				<v-card-title class="green--text">{{ commandInfo.name }}</v-card-title>
				<v-card-subtitle class="black--text">
					<strong>Description: </strong
					>{{ commandInfo.commandInfo.commandDescrition }}
				</v-card-subtitle>
				<v-row align="center" justify="center"> </v-row>
				<v-card-actions>
					<v-spacer></v-spacer>
					<v-btn color="blue">Try it Out</v-btn>
				</v-card-actions>
			</v-card>
		</v-col>
	</v-row>
</template>

<script>
	export default {
		data: () => ({
			commandInfo: {},
		}),
		watch: {
			$route() {
				this.commandInfo = {
					...this.$store.getters.getCommand(this.$route.params.command),
				}
			},
		},
		created() {
			this.commandInfo = {
				...this.$store.getters.getCommand(this.$route.params.command),
			}
		},
	}
</script>
