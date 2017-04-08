S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 8257
Date: 2017-04-06 03:29:43+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 8257, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002041
r2   = 0x00000006, r3   = 0xb40614c0
r4   = 0x00000002, r5   = 0xb4061000
r6   = 0xb675b09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5e89708
r10  = 0xb8ebdb18, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbec41ecc
lr   = 0xb6651f18, pc   = 0xb6650b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     79184 KB
Buffers:     61032 KB
Cached:     286388 KB
VmPeak:     133900 KB
VmSize:     133896 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28300 KB
VmRSS:       28300 KB
VmData:      45844 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8257 TID = 8257
8257 8258 8886 8887 8896 

Maps Information
af12e000 af92d000 rw-p [stack:8896]
b0f08000 b0f19000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f29000 b0f2e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1330000 b1338000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b134a000 b1b49000 rw-p [stack:8887]
b1b49000 b1b4a000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b5a000 b1b6e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b82000 b1b83000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b93000 b1b96000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1ba7000 b1ba8000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bb8000 b1bba000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bca000 b1bcc000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bdc000 b1bec000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bfc000 b1c08000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c1a000 b2419000 rw-p [stack:8886]
b274a000 b2751000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2764000 b276a000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b277a000 b2795000 r-xp /opt/usr/apps/org.example.client/bin/client
b28ed000 b29d0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a07000 b2a2f000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a41000 b3240000 rw-p [stack:8258]
b3240000 b3242000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3252000 b325c000 r-xp /lib/libnss_files-2.20-2014.11.so
b326d000 b3276000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3287000 b3298000 r-xp /lib/libnsl-2.20-2014.11.so
b32ab000 b32b1000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32c2000 b32c3000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32eb000 b32f2000 r-xp /usr/lib/libminizip.so.1.0.0
b3302000 b3307000 r-xp /usr/lib/libstorage.so.0.1
b3317000 b3376000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b338c000 b33a0000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33b0000 b33f4000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3404000 b340c000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b341c000 b344c000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b345f000 b3518000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b352c000 b357f000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3590000 b35ab000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35bb000 b367c000 r-xp /usr/lib/libprotobuf.so.9.0.1
b368f000 b369f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36af000 b36bc000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36cd000 b36d4000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36e4000 b3725000 r-xp /usr/lib/libmdm.so.1.2.12
b3735000 b373d000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b374c000 b375c000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b377d000 b37dd000 r-xp /usr/lib/libasound.so.2.0.0
b37ef000 b37f2000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3802000 b3805000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3815000 b381a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b382a000 b382b000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b383b000 b3846000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b385a000 b3861000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3871000 b3877000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3887000 b388c000 r-xp /usr/lib/libmmfsession.so.0.0.1
b389c000 b38b7000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38c7000 b38ce000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38de000 b38e1000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38f2000 b3920000 r-xp /usr/lib/libidn.so.11.5.44
b3930000 b3946000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3957000 b3961000 r-xp /usr/lib/libcares.so.2.1.0
b3971000 b397b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b398b000 b398d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b399d000 b399e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39ae000 b39b2000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39c3000 b39eb000 r-xp /usr/lib/libui-extension.so.0.1.0
b39fc000 b3a25000 r-xp /usr/lib/libturbojpeg.so
b3a45000 b3a4b000 r-xp /usr/lib/libgif.so.4.1.6
b3a5b000 b3aa1000 r-xp /usr/lib/libcurl.so.4.3.0
b3ab2000 b3ad3000 r-xp /usr/lib/libexif.so.12.3.3
b3aee000 b3b03000 r-xp /usr/lib/libtts.so
b3b14000 b3b1c000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b2c000 b3bf2000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c12000 b3d0a000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d29000 b3df7000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e0e000 b3e10000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e20000 b3e26000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e36000 b3e59000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e6a000 b3e6c000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e7c000 b3e7e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e8f000 b3e94000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eab000 b3ead000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ebd000 b3ec4000 r-xp /usr/lib/libsensord-share.so
b3ed4000 b3eec000 r-xp /usr/lib/libsensor.so.1.1.0
b3efd000 b3f00000 r-xp /usr/lib/libXv.so.1.0.0
b3f10000 b3f15000 r-xp /usr/lib/libutilX.so.1.1.0
b3f25000 b3f2a000 r-xp /usr/lib/libappcore-common.so.1.1
b3f3a000 b3f41000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f54000 b3f58000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f69000 b4047000 r-xp /usr/lib/libCOREGL.so.4.0
b4067000 b406a000 r-xp /usr/lib/libuuid.so.1.3.0
b407a000 b4091000 r-xp /usr/lib/libblkid.so.1.1.0
b40a2000 b40a4000 r-xp /usr/lib/libXau.so.6.0.0
b40b4000 b40fb000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b410d000 b4113000 r-xp /usr/lib/libjson-c.so.2.0.1
b4124000 b4128000 r-xp /usr/lib/libogg.so.0.7.1
b4138000 b415a000 r-xp /usr/lib/libvorbis.so.0.4.3
b416a000 b424e000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b426a000 b426d000 r-xp /usr/lib/libEGL.so.1.4
b427e000 b4284000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4294000 b4296000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42a6000 b42b3000 r-xp /usr/lib/libGLESv2.so.2.0
b42c4000 b4326000 r-xp /usr/lib/libpixman-1.so.0.28.2
b433b000 b4353000 r-xp /usr/lib/libmount.so.1.1.0
b4365000 b4379000 r-xp /usr/lib/libxcb.so.1.1.0
b4389000 b4390000 r-xp /lib/libcrypt-2.20-2014.11.so
b43c8000 b43ca000 r-xp /usr/lib/libiri.so
b43da000 b43e5000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43f6000 b442c000 r-xp /usr/lib/libpulse.so.0.16.2
b443d000 b4480000 r-xp /usr/lib/libsndfile.so.1.0.25
b4495000 b44aa000 r-xp /lib/libexpat.so.1.5.2
b44bc000 b457a000 r-xp /usr/lib/libcairo.so.2.11200.14
b458e000 b4596000 r-xp /usr/lib/libdrm.so.2.4.0
b45a6000 b45a9000 r-xp /usr/lib/libdri2.so.0.0.0
b45b9000 b4607000 r-xp /usr/lib/libssl.so.1.0.0
b461c000 b4628000 r-xp /usr/lib/libeeze.so.1.13.0
b4639000 b4642000 r-xp /usr/lib/libethumb.so.1.13.0
b4652000 b4655000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4665000 b481c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5607000 b5610000 r-xp /usr/lib/libXi.so.6.1.0
b5620000 b5622000 r-xp /usr/lib/libXgesture.so.7.0.0
b5632000 b5636000 r-xp /usr/lib/libXtst.so.6.1.0
b5646000 b564c000 r-xp /usr/lib/libXrender.so.1.3.0
b565c000 b5662000 r-xp /usr/lib/libXrandr.so.2.2.0
b5672000 b5674000 r-xp /usr/lib/libXinerama.so.1.0.0
b5685000 b5688000 r-xp /usr/lib/libXfixes.so.3.1.0
b5698000 b56a3000 r-xp /usr/lib/libXext.so.6.4.0
b56b3000 b56b5000 r-xp /usr/lib/libXdamage.so.1.1.0
b56c5000 b56c7000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56d7000 b57b9000 r-xp /usr/lib/libX11.so.6.3.0
b57cd000 b57d4000 r-xp /usr/lib/libXcursor.so.1.0.2
b57e4000 b57fc000 r-xp /usr/lib/libudev.so.1.6.0
b57fe000 b5801000 r-xp /lib/libattr.so.1.1.0
b5811000 b5831000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5832000 b5837000 r-xp /usr/lib/libffi.so.6.0.2
b5848000 b5860000 r-xp /lib/libz.so.1.2.8
b5870000 b5872000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5882000 b5957000 r-xp /usr/lib/libxml2.so.2.9.2
b596c000 b5a07000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a23000 b5a26000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a36000 b5a4f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a60000 b5a71000 r-xp /lib/libresolv-2.20-2014.11.so
b5a85000 b5aff000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b14000 b5b16000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b26000 b5b2d000 r-xp /usr/lib/libembryo.so.1.13.0
b5b3d000 b5b47000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b58000 b5b70000 r-xp /usr/lib/libpng12.so.0.50.0
b5b81000 b5ba4000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bc5000 b5bd9000 r-xp /usr/lib/libector.so.1.13.0
b5bea000 b5c02000 r-xp /usr/lib/liblua-5.1.so
b5c13000 b5c6a000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c7e000 b5ca6000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cb7000 b5cca000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cdb000 b5d15000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d26000 b5d34000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d44000 b5d4c000 r-xp /usr/lib/libtbm.so.1.0.0
b5d5c000 b5d69000 r-xp /usr/lib/libeio.so.1.13.0
b5d79000 b5d7b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d8b000 b5d90000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5da0000 b5db7000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc9000 b5de9000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df9000 b5e19000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e1b000 b5e21000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e31000 b5e42000 r-xp /usr/lib/libemotion.so.1.13.0
b5e53000 b5e5a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e6a000 b5e79000 r-xp /usr/lib/libeo.so.1.13.0
b5e8a000 b5e9c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ead000 b5eb2000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ec2000 b5edb000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5eeb000 b5f08000 r-xp /usr/lib/libeet.so.1.13.0
b5f21000 b5f69000 r-xp /usr/lib/libeina.so.1.13.0
b5f7a000 b5f8a000 r-xp /usr/lib/libefl.so.1.13.0
b5f9b000 b6080000 r-xp /usr/lib/libicuuc.so.51.1
b609d000 b61dd000 r-xp /usr/lib/libicui18n.so.51.1
b61f4000 b622c000 r-xp /usr/lib/libecore_x.so.1.13.0
b623e000 b6241000 r-xp /lib/libcap.so.2.21
b6251000 b627a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b628b000 b6292000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62a4000 b62db000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62ec000 b63d7000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63ea000 b6463000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6475000 b647a000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b648a000 b6494000 r-xp /usr/lib/libvconf.so.0.2.45
b64a4000 b64a6000 r-xp /usr/lib/libvasum.so.0.3.1
b64b6000 b64b8000 r-xp /usr/lib/libttrace.so.1.1
b64c8000 b64cb000 r-xp /usr/lib/libiniparser.so.0
b64db000 b6501000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6511000 b6516000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6527000 b653e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b654f000 b65ba000 r-xp /lib/libm-2.20-2014.11.so
b65cb000 b65d1000 r-xp /lib/librt-2.20-2014.11.so
b65e2000 b65ef000 r-xp /usr/lib/libunwind.so.8.0.1
b6625000 b6749000 r-xp /lib/libc-2.20-2014.11.so
b675e000 b6777000 r-xp /lib/libgcc_s-4.9.so.1
b6787000 b6869000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b687a000 b68a4000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68b5000 b68f1000 r-xp /usr/lib/libsystemd.so.0.4.0
b68f3000 b6976000 r-xp /usr/lib/libedje.so.1.13.0
b6989000 b69a7000 r-xp /usr/lib/libecore.so.1.13.0
b69c7000 b6b4e000 r-xp /usr/lib/libevas.so.1.13.0
b6b83000 b6b97000 r-xp /lib/libpthread-2.20-2014.11.so
b6bab000 b6ddf000 r-xp /usr/lib/libelementary.so.1.13.0
b6e0e000 b6e12000 r-xp /usr/lib/libsmack.so.1.0.0
b6e22000 b6e29000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e39000 b6e3b000 r-xp /usr/lib/libdlog.so.0.0.0
b6e4b000 b6e4e000 r-xp /usr/lib/libbundle.so.0.1.22
b6e5e000 b6e60000 r-xp /lib/libdl-2.20-2014.11.so
b6e71000 b6e89000 r-xp /usr/lib/libaul.so.0.1.0
b6e9d000 b6ea2000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eb3000 b6ec0000 r-xp /usr/lib/liblptcp.so
b6ed2000 b6ed6000 r-xp /usr/lib/libsys-assert.so
b6ee7000 b6f07000 r-xp /lib/ld-2.20-2014.11.so
b6f18000 b6f1d000 r-xp /usr/bin/launchpad-loader
b8b3a000 b8f19000 rw-p [heap]
bec22000 bec43000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8257)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6650b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-06 03:29:25.068+0900 I/MESSAGE_PORT( 8668): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-06 03:29:25.078+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:29:25.108+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:29:25.148+0900 I/Tizen::System( 1231): (280) > The screen has been turned on.
04-06 03:29:25.148+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:25.158+0900 W/LOCKSCREEN(  842): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
04-06 03:29:25.158+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
04-06 03:29:25.158+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
04-06 03:29:25.168+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:25.188+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7852 pgid = 7852
04-06 03:29:25.188+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(7852)
04-06 03:29:25.228+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 03:29:25.228+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 03:29:25.228+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 03:29:25.228+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 7852
04-06 03:29:25.228+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[7852] terminate event is forwarded
04-06 03:29:25.228+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:29:25.228+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 7852, ]
04-06 03:29:25.228+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:29:25.228+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 03:29:25.228+0900 I/Tizen::App( 1231): (512) > Not registered pid(7852)
04-06 03:29:25.228+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 03:29:25.228+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:25.228+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7852
04-06 03:29:25.238+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2004
04-06 03:29:25.248+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:25.248+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 7852.
04-06 03:29:25.418+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b7d6e8]
04-06 03:29:25.418+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 03:29:25.418+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b7d6e8
04-06 03:29:25.418+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 03:29:25.428+0900 W/LOCATION( 1448): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
04-06 03:29:25.428+0900 E/weather-common( 1448): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
04-06 03:29:25.448+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
04-06 03:29:25.448+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_update_cb(287) > received updating signal
04-06 03:29:25.448+0900 E/EFL     ( 1448): edje<1448> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-06 03:29:25.478+0900 E/EFL     ( 1448): evas_main<1448> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8003bdba is not stable during recalc loop
04-06 03:29:25.508+0900 E/EFL     ( 1448): evas_main<1448> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8003bdba is not stable during recalc loop
04-06 03:29:25.518+0900 E/EFL     ( 1448): edje<1448> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-06 03:29:25.528+0900 E/cluster-home(  858): cluster-data-list.cpp: GetDBoxID(1000) >  found id[5]
04-06 03:29:25.528+0900 W/cluster-view(  858): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 03:29:26.068+0900 E/weather-agent( 8668): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
04-06 03:29:26.068+0900 I/CAPI_APPFW_APPLICATION( 8668): service_app_main.c: service_app_exit(446) > service_app_exit
04-06 03:29:26.068+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 03:29:26.068+0900 E/weather-agent( 8668): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
04-06 03:29:26.068+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 03:29:26.219+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
04-06 03:29:26.219+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8668
04-06 03:29:26.219+0900 I/Tizen::App( 1231): (243) > App[com.samsung.weather-m-agent] pid[8668] terminate event is forwarded
04-06 03:29:26.219+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:29:26.219+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 8668, ]
04-06 03:29:26.219+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:29:26.219+0900 I/Tizen::App( 1231): (506) > TerminatedApp(com.samsung.weather-m-agent)
04-06 03:29:26.219+0900 I/Tizen::App( 1231): (512) > Not registered pid(8668)
04-06 03:29:26.219+0900 I/Tizen::System( 1231): (246) > Terminated app [com.samsung.weather-m-agent]
04-06 03:29:26.219+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:26.229+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 8668
04-06 03:29:26.229+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:26.229+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 8668.
04-06 03:29:26.639+0900 E/PKGMGR_SERVER( 8661): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:29:26.639+0900 E/PKGMGR_SERVER( 8661): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:29:26.719+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=214886082
04-06 03:29:26.839+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=214886203
04-06 03:29:26.839+0900 E/LOCKSCREEN(  842): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
04-06 03:29:26.839+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
04-06 03:29:26.839+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
04-06 03:29:26.839+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-06 03:29:26.839+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
04-06 03:29:26.839+0900 W/LOCKSCREEN(  842): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
04-06 03:29:26.839+0900 W/LOCKSCREEN(  842): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
04-06 03:29:26.839+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
04-06 03:29:26.839+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
04-06 03:29:26.839+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
04-06 03:29:26.839+0900 E/LOCKSCREEN(  842): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-06 03:29:27.170+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
04-06 03:29:27.170+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
04-06 03:29:27.170+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
04-06 03:29:27.170+0900 E/LOCKSCREEN(  842): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
04-06 03:29:27.170+0900 E/LOCKSCREEN(  842): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-06 03:29:27.170+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-06 03:29:27.170+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-06 03:29:27.170+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-06 03:29:27.170+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
04-06 03:29:27.190+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:27.190+0900 W/LOCKSCREEN(  842): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2A00007] is [invisible]
04-06 03:29:27.190+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
04-06 03:29:27.190+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
04-06 03:29:27.190+0900 E/LOCKSCREEN(  842): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
04-06 03:29:27.190+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:29:27.190+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:29:27.190+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:29:27.190+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:27.190+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(842) status(4)
04-06 03:29:27.190+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(842)
04-06 03:29:27.190+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 842, appid: com.samsung.lockscreen, status: bg
04-06 03:29:27.200+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: PAUSE State: RUNNING
04-06 03:29:27.200+0900 I/CAPI_APPFW_APPLICATION(  842): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:29:27.200+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-06 03:29:27.200+0900 E/LOCKSCREEN(  842): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-06 03:29:27.200+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
04-06 03:29:27.200+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
04-06 03:29:27.200+0900 W/LOCKSCREEN(  842): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-06 03:29:27.200+0900 E/LOCKSCREEN(  842): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-06 03:29:27.200+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:29:27.230+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [com.samsun] 
04-06 03:29:27.230+0900 I/Tizen::System( 1231): (273) > Current App[com.samsun] is already actived.
04-06 03:29:27.230+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 03:29:27.230+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: MEM_FLUSH State: PAUSED
04-06 03:29:27.250+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:29:27.250+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:29:27.260+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b6d6b8]
04-06 03:29:27.260+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 03:29:27.260+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b6d6b8
04-06 03:29:27.270+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 03:29:27.280+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 03:29:27.280+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 03:29:27.280+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 03:29:27.280+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 03:29:27.290+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
04-06 03:29:27.290+0900 E/LOCKSCREEN(  842): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-06 03:29:27.290+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-06 03:29:27.290+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-06 03:29:27.290+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-06 03:29:27.300+0900 E/LOCKSCREEN(  842): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
04-06 03:29:28.901+0900 E/PKGMGR  ( 8764): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-06 03:29:28.981+0900 E/PKGMGR_SERVER( 8766): pkgmgr-server.c: main(2414) > package manager server start
04-06 03:29:29.031+0900 E/PKGMGR_SERVER( 8766): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-06 03:29:29.031+0900 E/PKGMGR_SERVER( 8766): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-06 03:29:29.041+0900 E/PKGMGR  ( 8764): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[87640002]
04-06 03:29:29.192+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-06 03:29:29.192+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-06 03:29:29.192+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.192+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.192+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.192+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.192+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-06 03:29:29.202+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.202+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 03:29:29.202+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 03:29:29.202+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.202+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-06 03:29:29.202+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.202+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.342+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 03:29:29.342+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 03:29:29.352+0900 W/CERT_SVC_VCORE( 8769): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 03:29:29.432+0900 E/rpm-installer( 8769): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-06 03:29:29.432+0900 E/rpm-installer( 8769): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-06 03:29:29.492+0900 E/PKGMGR_PARSER( 8769): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-06 03:29:29.512+0900 I/PRIVACY-MANAGER-CLIENT( 8769): SocketClient.cpp: SocketClient(37) > Client created
04-06 03:29:29.512+0900 I/PRIVACY-MANAGER-CLIENT( 8769): SocketClient.cpp: connect(62) > Client connected
04-06 03:29:29.512+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-06 03:29:29.512+0900 I/PRIVACY-MANAGER-CLIENT( 8769): SocketClient.cpp: disconnect(72) > Client disconnected
04-06 03:29:29.512+0900 E/PKGMGR_CERT( 8769): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-06 03:29:29.522+0900 E/PKGMGR_CERT( 8769): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-06 03:29:29.522+0900 E/PKGMGR_CERT( 8769): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-06 03:29:29.562+0900 E/rpm-installer( 8769): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-06 03:29:29.562+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-06 03:29:29.562+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-06 03:29:29.562+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.562+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.562+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.562+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.562+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-06 03:29:29.572+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-06 03:29:29.572+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-06 03:29:29.572+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-06 03:29:31.083+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 03:29:31.234+0900 E/PKGMGR_SERVER( 8766): pkgmgr-server.c: sighandler(417) > child NORMAL exit [8769]
04-06 03:29:31.634+0900 E/PKGMGR_SERVER( 8766): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:29:31.634+0900 E/PKGMGR_SERVER( 8766): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:29:32.194+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: MEM_FLUSH State: PAUSED
04-06 03:29:32.425+0900 E/PKGMGR  ( 8819): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-06 03:29:32.505+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: main(2414) > package manager server start
04-06 03:29:32.545+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-06 03:29:32.555+0900 E/PKGMGR_INFO( 8821): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-06 03:29:32.565+0900 E/rpm-installer( 8821): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-06 03:29:32.575+0900 E/PKGMGR_SERVER( 8821): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-06 03:29:32.575+0900 E/PKGMGR  ( 8819): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[88190002]
04-06 03:29:32.695+0900 E/PKGMGR_INSTALLER( 8824): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-06 03:29:32.695+0900 E/rpm-installer( 8824): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-06 03:29:32.705+0900 E/rpm-installer( 8824): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-06 03:29:32.705+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-06 03:29:32.705+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 03:29:32.705+0900 E/rpm-installer( 8824): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-06 03:29:32.705+0900 E/rpm-installer( 8824): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 03:29:32.765+0900 W/CERT_SVC_VCORE( 8824): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 03:29:32.815+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.815+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-06 03:29:32.815+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.815+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-06 03:29:32.815+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.815+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.825+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 03:29:32.825+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.825+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.825+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 03:29:32.825+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-06 03:29:32.825+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.825+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.035+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-06 03:29:33.045+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-06 03:29:33.045+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-06 03:29:33.045+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 03:29:33.045+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-06 03:29:33.045+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-06 03:29:33.045+0900 E/PKGMGR_PARSER( 8824): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-06 03:29:33.055+0900 E/PKGMGR_PARSER( 8824): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-06 03:29:33.085+0900 I/PRIVACY-MANAGER-CLIENT( 8824): SocketClient.cpp: SocketClient(37) > Client created
04-06 03:29:33.306+0900 E/PKGMGR_PARSER( 8824): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-06 03:29:33.316+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-06 03:29:33.336+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.336+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.336+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.336+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.336+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-06 03:29:33.336+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-06 03:29:33.336+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-06 03:29:33.346+0900 E/rpm-installer( 8824): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 03:29:33.376+0900 E/rpm-installer( 8824): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-06 03:29:33.376+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.376+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.376+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.376+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.376+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-06 03:29:33.376+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-06 03:29:33.376+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-06 03:29:34.637+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 03:29:35.187+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:35.187+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:35.187+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:35.187+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-06 03:29:35.187+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-06 03:29:35.187+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-06 03:29:35.207+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-06 03:29:35.207+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-06 03:29:35.207+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-06 03:29:35.207+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:35.227+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-06 03:29:35.237+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-06 03:29:35.237+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-06 03:29:35.237+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-06 03:29:35.237+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-06 03:29:35.237+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-06 03:29:35.237+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-06 03:29:35.237+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-06 03:29:35.247+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: sighandler(417) > child NORMAL exit [8824]
04-06 03:29:35.247+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 03:29:35.247+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 03:29:35.247+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-06 03:29:35.247+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-06 03:29:35.247+0900 I/Tizen::App( 1231): (840) > Enter.
04-06 03:29:35.257+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-06 03:29:35.257+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-06 03:29:35.257+0900 I/Tizen::App( 1231): (703) > Exit.
04-06 03:29:35.257+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-06 03:29:35.257+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-06 03:29:35.257+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (131) > Enter
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (883) > Exit.
04-06 03:29:35.277+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-06 03:29:35.297+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-06 03:29:36.639+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:29:36.639+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:29:39.672+0900 W/AUL     ( 8879): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 03:29:39.672+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 03:29:39.682+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 03:29:39.692+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 03:29:39.692+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 03:29:39.692+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 8879
04-06 03:29:39.692+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 03:29:39.702+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 03:29:39.702+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 03:29:39.712+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 03:29:39.712+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 03:29:39.712+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 03:29:39.732+0900 I/abc     ( 8257): abc
04-06 03:29:39.732+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: ui_app_main(789) > app_efl_main
04-06 03:29:39.732+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 03:29:39.762+0900 E/TBM     ( 8257): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 03:29:39.812+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8257, appid: org.example.client
04-06 03:29:39.812+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 03:29:39.812+0900 W/AUL     ( 8879): launch.c: app_request_to_launchpad(425) > request cmd(0) result(8257)
04-06 03:29:40.022+0900 D/basicui ( 8257): successed to load edc file
04-06 03:29:40.052+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:40.052+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:40.072+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 03:29:40.072+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:40.072+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:40.092+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:29:40.112+0900 I/MY_LOG  ( 8257): change
04-06 03:29:40.152+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(514) > [APP 8257] Event: RESET State: CREATED
04-06 03:29:40.152+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 03:29:40.162+0900 E/EFL     ( 8257): edje<8257> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:29:40.162+0900 E/EFL     ( 8257): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:29:40.172+0900 E/EFL     ( 8257): edje<8257> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:29:40.172+0900 E/EFL     ( 8257): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:29:40.172+0900 E/EFL     ( 8257): edje<8257> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:29:40.172+0900 E/EFL     ( 8257): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:29:40.182+0900 W/APP_CORE( 8257): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7200002
04-06 03:29:40.182+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 03:29:40.282+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 03:29:40.282+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:29:40.282+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 03:29:40.292+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 03:29:40.292+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8257) status(3)
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:29:40.292+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(8257)
04-06 03:29:40.292+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8257, appid: org.example.client, status: fg
04-06 03:29:40.292+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(514) > [APP 8257] Event: RESUME State: CREATED
04-06 03:29:40.312+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 03:29:40.312+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 03:29:40.312+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 03:29:40.312+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 03:29:40.312+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(625) > [APP 8257] Initial Launching, call the resume_cb
04-06 03:29:40.312+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:29:40.663+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8257) status(0)
04-06 03:29:40.873+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2014
04-06 03:29:40.883+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 03:29:40.883+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 8257.
04-06 03:29:41.644+0900 I/UXT     ( 8892): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 03:29:42.995+0900 E/EFL     ( 8257): ecore_x<8257> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=214902361
04-06 03:29:42.995+0900 I/MY_LOG  ( 8257): Button pressed
04-06 03:29:43.105+0900 E/EFL     ( 8257): ecore_x<8257> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=214902471
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: vconf_get_bool(2729) > vconf_get_bool(8257) : db/ise/keysound error
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 03:29:43.165+0900 I/MY_LOG  ( 8257): Button unpressed
04-06 03:29:43.295+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8257 pgid = 8257
04-06 03:29:43.295+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(8257)
04-06 03:29:43.295+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:43.315+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 03:29:43.315+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:29:43.315+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:29:43.325+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 03:29:43.325+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 03:29:43.355+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 03:29:43.355+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 03:29:43.355+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 03:29:43.355+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 03:29:43.365+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[8257] terminate event is forwarded
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 8257, ]
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:29:43.365+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 03:29:43.365+0900 I/Tizen::App( 1231): (512) > Not registered pid(8257)
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 03:29:43.365+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:43.365+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 8257
04-06 03:29:43.365+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8257
04-06 03:29:43.365+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8257
04-06 03:29:43.375+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:29:43.375+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:29:43.375+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:29:43.375+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:43.385+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:29:43.415+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:43.415+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 8257.
04-06 03:29:43.415+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 03:29:43.425+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 03:29:43.425+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:43.455+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:43.465+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:29:43.475+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b450c8]
04-06 03:29:43.475+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 03:29:43.475+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b450c8
04-06 03:29:43.475+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 03:29:43.475+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:29:43.475+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 03:29:43.485+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 03:29:43.485+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 03:29:43.485+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 03:29:43.485+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 03:29:43.485+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 03:29:43.485+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:29:43.485+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:29:43.546+0900 W/CRASH_MANAGER( 8901): worker.c: worker_job(1199) > 0608257636c69149141698
