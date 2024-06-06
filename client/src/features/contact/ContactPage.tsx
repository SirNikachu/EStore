import { LoadingButton } from '@mui/lab';
import { Container, Paper, Avatar, Typography, Box, TextField, Grid } from '@mui/material';
import { useForm } from 'react-hook-form';
import { useNavigate } from 'react-router-dom';
import agent from '../../app/api/agent';
import EmailIcon from '@mui/icons-material/Email';
import { toast } from 'react-toastify';

export default function ContactPage() {
    const navigate = useNavigate();
    const { register, handleSubmit, setError, formState: { isSubmitting, errors, isValid } } = useForm({
        mode: 'onTouched'
    });

    function handleApiErrors(errors: any) {
        console.log(errors);
        if (errors) {
            errors.forEach((error: string) => {
                if (error.includes('Password')) {
                    setError('password', { message: error })
                } else if (error.includes('Email')) {
                    setError('email', { message: error })
                } else if (error.includes('Username')) {
                    setError('username', { message: error })
                }
            });
        }
    }

    return (
        <Container component={Paper} maxWidth='sm' sx={{ p: 4, display: 'flex', flexDirection: 'column', alignItems: 'center' }}>
            <Avatar sx={{ m: 1, bgcolor: 'secondary.main' }}>
                <EmailIcon />
            </Avatar>
            <Typography component="h1" variant="h5">
                Contact Us
            </Typography>
            <Box component="form"
                onSubmit={()=> toast.success('Registration successful - you can now login')}
                noValidate sx={{ mt: 1 }}
            >
                <TextField
                    margin="normal"
                    required
                    fullWidth
                    autoFocus
                    label="Name"
                    {...register('username', { required: 'Name is required' })}
                    error={!!errors.username}
                    helperText={errors?.username?.message as string}
                />
                <TextField
                    margin="normal"
                    required
                    fullWidth
                    label="Email"
                    {...register('email', { 
                        required: 'Email is required',
                        pattern: {
                            value: /^\w+[\w-.]*@\w+((-\w+)|(\w*))\.[a-z]{2,3}$/,
                            message: 'Not a valid email address'
                        }
                    })}
                    error={!!errors.email}
                    helperText={errors?.email?.message as string}
                />
                <TextField
                    margin="normal"
                    required
                    fullWidth
                    label="Message"
                    {...register('message', { 
                        required: 'Message is required'
                    })}
                    error={!!errors.email}
                    helperText={errors?.email?.message as string}
                    rows={4}
                    multiline
                />
                <LoadingButton
                    loading={isSubmitting}
                    disabled={!isValid}
                    type="submit"
                    fullWidth
                    variant="contained"
                    sx={{ mt: 3, mb: 2 }}
                >
                    Send
                </LoadingButton>

            </Box>
        </Container>
    );
}